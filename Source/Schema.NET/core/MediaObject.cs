namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// A media object, such as an image, video, or audio object embedded in a web page or a downloadable dataset i.e. DataDownload. Note that a creative work may have many media objects associated with it on the same web page. For example, a page about a single song (MusicRecording) may have a music video (VideoObject), and a high and low bandwidth audio stream (2 AudioObject's).
    /// </summary>
    public partial interface IMediaObject : ICreativeWork
    {
        /// <summary>
        /// A NewsArticle associated with the Media Object.
        /// </summary>
        OneOrMany<INewsArticle>? AssociatedArticle { get; set; }

        /// <summary>
        /// The bitrate of the media object.
        /// </summary>
        OneOrMany<string>? Bitrate { get; set; }

        /// <summary>
        /// File size in (mega/kilo) bytes.
        /// </summary>
        OneOrMany<string>? ContentSize { get; set; }

        /// <summary>
        /// Actual bytes of the media object, for example the image file or video file.
        /// </summary>
        OneOrMany<Uri>? ContentUrl { get; set; }

        /// <summary>
        /// The duration of the item (movie, audio recording, event, etc.) in &lt;a href="http://en.wikipedia.org/wiki/ISO_8601"&gt;ISO 8601 date format&lt;/a&gt;.
        /// </summary>
        OneOrMany<TimeSpan?>? Duration { get; set; }

        /// <summary>
        /// A URL pointing to a player for a specific video. In general, this is the information in the &lt;code&gt;src&lt;/code&gt; element of an &lt;code&gt;embed&lt;/code&gt; tag and should not be the same as the content of the &lt;code&gt;loc&lt;/code&gt; tag.
        /// </summary>
        OneOrMany<Uri>? EmbedUrl { get; set; }

        /// <summary>
        /// The CreativeWork encoded by this media object.
        /// </summary>
        OneOrMany<ICreativeWork>? EncodesCreativeWork { get; set; }

        /// <summary>
        /// mp3, mpeg4, etc.
        /// </summary>
        OneOrMany<string>? EncodingFormat { get; set; }

        /// <summary>
        /// The height of the item.
        /// </summary>
        Values<string, IQuantitativeValue, int>? Height { get; set; }

        /// <summary>
        /// Player type required&amp;#x2014;for example, Flash or Silverlight.
        /// </summary>
        OneOrMany<string>? PlayerType { get; set; }

        /// <summary>
        /// The production company or studio responsible for the item e.g. series, video game, episode etc.
        /// </summary>
        OneOrMany<IOrganization>? ProductionCompany { get; set; }

        /// <summary>
        /// The regions where the media is allowed. If not specified, then it's assumed to be allowed everywhere. Specify the countries in &lt;a href="http://en.wikipedia.org/wiki/ISO_3166"&gt;ISO 3166 format&lt;/a&gt;.
        /// </summary>
        OneOrMany<IPlace>? RegionsAllowed { get; set; }

        /// <summary>
        /// Indicates if use of the media require a subscription  (either paid or free). Allowed values are &lt;code&gt;true&lt;/code&gt; or &lt;code&gt;false&lt;/code&gt; (note that an earlier version had 'yes', 'no').
        /// </summary>
        OneOrMany<bool?>? RequiresSubscription { get; set; }

        /// <summary>
        /// Date when this media object was uploaded to this site.
        /// </summary>
        OneOrMany<DateTimeOffset?>? UploadDate { get; set; }

        /// <summary>
        /// The width of the item.
        /// </summary>
        Values<string, IQuantitativeValue, int>? Width { get; set; }
    }

    /// <summary>
    /// A media object, such as an image, video, or audio object embedded in a web page or a downloadable dataset i.e. DataDownload. Note that a creative work may have many media objects associated with it on the same web page. For example, a page about a single song (MusicRecording) may have a music video (VideoObject), and a high and low bandwidth audio stream (2 AudioObject's).
    /// </summary>
    [DataContract]
    public partial class MediaObject : CreativeWork, IMediaObject
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "MediaObject";

        /// <summary>
        /// A NewsArticle associated with the Media Object.
        /// </summary>
        [DataMember(Name = "associatedArticle", Order = 206)]
        [JsonConverter(typeof(ValuesConverter))]
        public OneOrMany<INewsArticle>? AssociatedArticle { get; set; }

        /// <summary>
        /// The bitrate of the media object.
        /// </summary>
        [DataMember(Name = "bitrate", Order = 207)]
        [JsonConverter(typeof(ValuesConverter))]
        public OneOrMany<string>? Bitrate { get; set; }

        /// <summary>
        /// File size in (mega/kilo) bytes.
        /// </summary>
        [DataMember(Name = "contentSize", Order = 208)]
        [JsonConverter(typeof(ValuesConverter))]
        public OneOrMany<string>? ContentSize { get; set; }

        /// <summary>
        /// Actual bytes of the media object, for example the image file or video file.
        /// </summary>
        [DataMember(Name = "contentUrl", Order = 209)]
        [JsonConverter(typeof(ValuesConverter))]
        public OneOrMany<Uri>? ContentUrl { get; set; }

        /// <summary>
        /// The duration of the item (movie, audio recording, event, etc.) in &lt;a href="http://en.wikipedia.org/wiki/ISO_8601"&gt;ISO 8601 date format&lt;/a&gt;.
        /// </summary>
        [DataMember(Name = "duration", Order = 210)]
        [JsonConverter(typeof(TimeSpanToISO8601DurationValuesConverter))]
        public OneOrMany<TimeSpan?>? Duration { get; set; }

        /// <summary>
        /// A URL pointing to a player for a specific video. In general, this is the information in the &lt;code&gt;src&lt;/code&gt; element of an &lt;code&gt;embed&lt;/code&gt; tag and should not be the same as the content of the &lt;code&gt;loc&lt;/code&gt; tag.
        /// </summary>
        [DataMember(Name = "embedUrl", Order = 211)]
        [JsonConverter(typeof(ValuesConverter))]
        public OneOrMany<Uri>? EmbedUrl { get; set; }

        /// <summary>
        /// The CreativeWork encoded by this media object.
        /// </summary>
        [DataMember(Name = "encodesCreativeWork", Order = 212)]
        [JsonConverter(typeof(ValuesConverter))]
        public OneOrMany<ICreativeWork>? EncodesCreativeWork { get; set; }

        /// <summary>
        /// mp3, mpeg4, etc.
        /// </summary>
        [DataMember(Name = "encodingFormat", Order = 213)]
        [JsonConverter(typeof(ValuesConverter))]
        public OneOrMany<string>? EncodingFormat { get; set; }

        /// <summary>
        /// The height of the item.
        /// </summary>
        [DataMember(Name = "height", Order = 214)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<string, IQuantitativeValue, int>? Height { get; set; }

        /// <summary>
        /// Player type required&amp;#x2014;for example, Flash or Silverlight.
        /// </summary>
        [DataMember(Name = "playerType", Order = 215)]
        [JsonConverter(typeof(ValuesConverter))]
        public OneOrMany<string>? PlayerType { get; set; }

        /// <summary>
        /// The production company or studio responsible for the item e.g. series, video game, episode etc.
        /// </summary>
        [DataMember(Name = "productionCompany", Order = 216)]
        [JsonConverter(typeof(ValuesConverter))]
        public OneOrMany<IOrganization>? ProductionCompany { get; set; }

        /// <summary>
        /// The regions where the media is allowed. If not specified, then it's assumed to be allowed everywhere. Specify the countries in &lt;a href="http://en.wikipedia.org/wiki/ISO_3166"&gt;ISO 3166 format&lt;/a&gt;.
        /// </summary>
        [DataMember(Name = "regionsAllowed", Order = 217)]
        [JsonConverter(typeof(ValuesConverter))]
        public OneOrMany<IPlace>? RegionsAllowed { get; set; }

        /// <summary>
        /// Indicates if use of the media require a subscription  (either paid or free). Allowed values are &lt;code&gt;true&lt;/code&gt; or &lt;code&gt;false&lt;/code&gt; (note that an earlier version had 'yes', 'no').
        /// </summary>
        [DataMember(Name = "requiresSubscription", Order = 218)]
        [JsonConverter(typeof(ValuesConverter))]
        public OneOrMany<bool?>? RequiresSubscription { get; set; }

        /// <summary>
        /// Date when this media object was uploaded to this site.
        /// </summary>
        [DataMember(Name = "uploadDate", Order = 219)]
        [JsonConverter(typeof(ValuesConverter))]
        public OneOrMany<DateTimeOffset?>? UploadDate { get; set; }

        /// <summary>
        /// The width of the item.
        /// </summary>
        [DataMember(Name = "width", Order = 220)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<string, IQuantitativeValue, int>? Width { get; set; }
    }
}
