using EPiServer.DataAbstraction;
using EPiServer.Framework;
using EPiServer.Framework.Initialization;
using EPiServer.ServiceLocation;
using System;
using System.Collections.Generic;

namespace EpiRevision.Business.Initializers
{
    [InitializableModule]
    public class CategoryInitialization : IInitializableModule
    {
        public void Initialize(InitializationEngine context)
        {
            CreateCategories();
        }

        private void CreateCategories()
        {
            var categoryRepository = ServiceLocator.Current.GetInstance<CategoryRepository>();
            var root = categoryRepository.GetRoot();

            if (categoryRepository.Get("[FootballTeam]") == null)
            {
                var systemCategory = new Category(root, "[FootballTeam]")
                {
                    Description = "[FootballTeam]",
                    Selectable = false
                };

                categoryRepository.Save(systemCategory);

                var system = categoryRepository.Get("[FootballTeam]");

                var team = new Category(system, "Djurgården")
                {
                    Description = "Djurgården",
                    Selectable = false
                };
                
                categoryRepository.Save(team);
            }

            if (categoryRepository.Get("Djurgården") != null)
            {
                var team = categoryRepository.Get("Djurgården");

                var categories = new List<string>
                {
                    "Damer",
                    "Herrar",
                    "Juniorer"
                };

                foreach(var cat in categories)
                {
                    if (categoryRepository.Get(cat) == null)
                    {
                        var newCat = new Category(team, cat)
                        {
                            Description = cat
                        };

                        categoryRepository.Save(newCat);
                    }
                }
            }
        }

        public void Uninitialize(InitializationEngine context)
        {
            throw new NotImplementedException();
        }
    }
}