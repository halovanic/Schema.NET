namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// A video game is an electronic game that involves human interaction with a user interface to generate visual feedback on a video device.
    /// </summary>
    public partial interface IVideoGame : IGameAndSoftwareApplication
    {
        /// <summary>
        /// An actor, e.g. in tv, radio, movie, video games etc., or in an event. Actors can be associated with individual items or with a series, episode, clip.
        /// </summary>
        OneOrMany<IPerson>? Actor { get; set; }

        /// <summary>
        /// Cheat codes to the game.
        /// </summary>
        OneOrMany<ICreativeWork>? CheatCode { get; set; }

        /// <summary>
        /// A director of e.g. tv, radio, movie, video gaming etc. content, or of an event. Directors can be associated with individual items or with a series, episode, clip.
        /// </summary>
        OneOrMany<IPerson>? Director { get; set; }

        /// <summary>
        /// The electronic systems used to play &lt;a href="http://en.wikipedia.org/wiki/Category:Video_game_platforms"&gt;video games&lt;/a&gt;.
        /// </summary>
        Values<string, IThing, Uri>? GamePlatform { get; set; }

        /// <summary>
        /// The server on which  it is possible to play the game.
        /// </summary>
        OneOrMany<IGameServer>? GameServer { get; set; }

        /// <summary>
        /// Links to tips, tactics, etc.
        /// </summary>
        OneOrMany<ICreativeWork>? GameTip { get; set; }

        /// <summary>
        /// The composer of the soundtrack.
        /// </summary>
        Values<IMusicGroup, IPerson>? MusicBy { get; set; }

        /// <summary>
        /// Indicates whether this game is multi-player, co-op or single-player.  The game can be marked as multi-player, co-op and single-player at the same time.
        /// </summary>
        OneOrMany<GamePlayMode?>? PlayMode { get; set; }

        /// <summary>
        /// The trailer of a movie or tv/radio series, season, episode, etc.
        /// </summary>
        OneOrMany<IVideoObject>? Trailer { get; set; }
    }

    /// <summary>
    /// A video game is an electronic game that involves human interaction with a user interface to generate visual feedback on a video device.
    /// </summary>
    [DataContract]
    public partial class VideoGame : GameAndSoftwareApplication, IVideoGame
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "VideoGame";

        /// <summary>
        /// An actor, e.g. in tv, radio, movie, video games etc., or in an event. Actors can be associated with individual items or with a series, episode, clip.
        /// </summary>
        [DataMember(Name = "actor", Order = 306)]
        [JsonConverter(typeof(ValuesConverter))]
        public OneOrMany<IPerson>? Actor { get; set; }

        /// <summary>
        /// Cheat codes to the game.
        /// </summary>
        [DataMember(Name = "cheatCode", Order = 307)]
        [JsonConverter(typeof(ValuesConverter))]
        public OneOrMany<ICreativeWork>? CheatCode { get; set; }

        /// <summary>
        /// A director of e.g. tv, radio, movie, video gaming etc. content, or of an event. Directors can be associated with individual items or with a series, episode, clip.
        /// </summary>
        [DataMember(Name = "director", Order = 308)]
        [JsonConverter(typeof(ValuesConverter))]
        public OneOrMany<IPerson>? Director { get; set; }

        /// <summary>
        /// The electronic systems used to play &lt;a href="http://en.wikipedia.org/wiki/Category:Video_game_platforms"&gt;video games&lt;/a&gt;.
        /// </summary>
        [DataMember(Name = "gamePlatform", Order = 309)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<string, IThing, Uri>? GamePlatform { get; set; }

        /// <summary>
        /// The server on which  it is possible to play the game.
        /// </summary>
        [DataMember(Name = "gameServer", Order = 310)]
        [JsonConverter(typeof(ValuesConverter))]
        public OneOrMany<IGameServer>? GameServer { get; set; }

        /// <summary>
        /// Links to tips, tactics, etc.
        /// </summary>
        [DataMember(Name = "gameTip", Order = 311)]
        [JsonConverter(typeof(ValuesConverter))]
        public OneOrMany<ICreativeWork>? GameTip { get; set; }

        /// <summary>
        /// The composer of the soundtrack.
        /// </summary>
        [DataMember(Name = "musicBy", Order = 312)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<IMusicGroup, IPerson>? MusicBy { get; set; }

        /// <summary>
        /// Indicates whether this game is multi-player, co-op or single-player.  The game can be marked as multi-player, co-op and single-player at the same time.
        /// </summary>
        [DataMember(Name = "playMode", Order = 313)]
        [JsonConverter(typeof(ValuesConverter))]
        public OneOrMany<GamePlayMode?>? PlayMode { get; set; }

        /// <summary>
        /// The trailer of a movie or tv/radio series, season, episode, etc.
        /// </summary>
        [DataMember(Name = "trailer", Order = 314)]
        [JsonConverter(typeof(ValuesConverter))]
        public OneOrMany<IVideoObject>? Trailer { get; set; }
    }
}
