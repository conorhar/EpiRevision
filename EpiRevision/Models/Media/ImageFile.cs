using EPiServer.Core;
using EPiServer.DataAnnotations;
using EPiServer.Framework.DataAnnotations;

namespace NackademinDemo.Models.Media
{
    [ContentType(
        GUID = "6EEDEEFF-28B2-4576-AFB7-3258577AE7D3"
    )]
    [MediaDescriptor(
        ExtensionString = "jpg,jpeg,jpe,ico,gif,bmp,png"
    )]
    public class ImageFile : ImageData
    {
    }
}