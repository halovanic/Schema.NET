namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// &lt;p&gt;The act of posing a question / favor to someone.&lt;/p&gt;
    /// &lt;p&gt;Related actions:&lt;/p&gt;
    /// &lt;ul&gt;
    /// &lt;li&gt;&lt;a class="localLink" href="http://schema.org/ReplyAction"&gt;ReplyAction&lt;/a&gt;: Appears generally as a response to AskAction.&lt;/li&gt;
    /// &lt;/ul&gt;
    /// </summary>
    public partial interface IAskAction : ICommunicateAction
    {
        /// <summary>
        /// A sub property of object. A question.
        /// </summary>
        OneOrMany<IQuestion>? Question { get; set; }
    }

    /// <summary>
    /// &lt;p&gt;The act of posing a question / favor to someone.&lt;/p&gt;
    /// &lt;p&gt;Related actions:&lt;/p&gt;
    /// &lt;ul&gt;
    /// &lt;li&gt;&lt;a class="localLink" href="http://schema.org/ReplyAction"&gt;ReplyAction&lt;/a&gt;: Appears generally as a response to AskAction.&lt;/li&gt;
    /// &lt;/ul&gt;
    /// </summary>
    [DataContract]
    public partial class AskAction : CommunicateAction, IAskAction
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "AskAction";

        /// <summary>
        /// A sub property of object. A question.
        /// </summary>
        [DataMember(Name = "question", Order = 406)]
        [JsonConverter(typeof(ValuesConverter))]
        public OneOrMany<IQuestion>? Question { get; set; }
    }
}
