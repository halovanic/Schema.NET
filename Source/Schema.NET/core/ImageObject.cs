namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// An image file.
    /// </summary>
    public partial interface IImageObject : IMediaObject
    {
        /// <summary>
        /// The caption for this object.
        /// </summary>
        OneOrMany<string>? Caption { get; set; }

        /// <summary>
        /// exif data for this object.
        /// </summary>
        Values<IPropertyValue, string>? ExifData { get; set; }

        /// <summary>
        /// Indicates whether this image is representative of the content of the page.
        /// </summary>
        OneOrMany<bool?>? RepresentativeOfPage { get; set; }

        /// <summary>
        /// Thumbnail image for an image or video.
        /// </summary>
        OneOrMany<IImageObject>? Thumbnail { get; set; }
    }

    /// <summary>
    /// An image file.
    /// </summary>
    [DataContract]
    public partial class ImageObject : MediaObject, IImageObject
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "ImageObject";

        /// <summary>
        /// The caption for this object.
        /// </summary>
        [DataMember(Name = "caption", Order = 306)]
        [JsonConverter(typeof(ValuesConverter))]
        public OneOrMany<string>? Caption { get; set; }

        /// <summary>
        /// exif data for this object.
        /// </summary>
        [DataMember(Name = "exifData", Order = 307)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<IPropertyValue, string>? ExifData { get; set; }

        /// <summary>
        /// Indicates whether this image is representative of the content of the page.
        /// </summary>
        [DataMember(Name = "representativeOfPage", Order = 308)]
        [JsonConverter(typeof(ValuesConverter))]
        public OneOrMany<bool?>? RepresentativeOfPage { get; set; }

        /// <summary>
        /// Thumbnail image for an image or video.
        /// </summary>
        [DataMember(Name = "thumbnail", Order = 309)]
        [JsonConverter(typeof(ValuesConverter))]
        public OneOrMany<IImageObject>? Thumbnail { get; set; }
    }
}
