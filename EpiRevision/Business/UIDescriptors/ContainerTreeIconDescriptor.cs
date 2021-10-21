using EpiRevision.Models;
using EPiServer.Shell;

namespace EpiRevision.Business.UIDescriptors
{
    [UIDescriptorRegistration]
    public class ContainerTreeIconDescriptor : UIDescriptor<IUseContainerTreeIcon>
    {
        public ContainerTreeIconDescriptor()
        {
            IconClass = EpiserverDefaultContentIcons.ObjectIcons.Container;
        }
    }

    public interface IUseContainerTreeIcon
    {
    }
}