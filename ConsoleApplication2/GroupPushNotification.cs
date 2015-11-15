// ------------------------------------------------------------------------------
// <summary>File for the GroupPushNotification class.</summary>
// <copyright file="GroupPushNotification.cs" company="Microsoft">
//     Copyright (c) Microsoft Corporation.  All rights reserved.
// </copyright>                         
// ------------------------------------------------------------------------------               
namespace Microsoft.OutlookApps.Groupies.GroupiesApi.DataContracts
{
    using System.Runtime.Serialization;


    /// <summary>
    /// implementation of ConversationPayloadFields
    /// </summary>
    public enum ConversationPayloadFields
    {
        /// <summary>
        /// The group
        /// </summary>
        group,

        /// <summary>
        /// The notification unique identifier
        /// </summary>
        notificationUniqueId,

        /// <summary>
        /// The sound
        /// </summary>
        sound,

        /// <summary>
        /// The preview
        /// </summary>
        preview,

        /// <summary>
        /// The MSG identifier
        /// </summary>
        msgId,

        /// <summary>
        /// From item
        /// </summary>
        from,

        /// <summary>
        /// The alert MSG
        /// </summary>
        alertMsg,

        /// <summary>
        /// The conversation identifier
        /// </summary>
        convId,

        /// <summary>
        /// The delivery time
        /// </summary>
        deliveryTime,

        /// <summary>
        /// The delivery time
        /// </summary>
        dmPayloadProperty,
    }

    /// <summary>
    /// The implementation of GroupPushNotification. 
    /// </summary>                    
    [DataContract(Name = "n")]
    public class GroupPushNotification
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GroupPushNotification"/> class.
        /// </summary>
        public GroupPushNotification()
        {
        }

        /// <summary>
        /// Gets or sets the conversation identifier.
        /// note this is a string because the client expects that. Think about backwards compatibility if you change this
        /// </summary>
        /// <value>
        /// The conversation identifier.
        /// </value>
        [DataMember(Name = "cId", IsRequired = true)]
        public string ConversationId
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the message identifier.
        /// note this is a string because the client expects that. Think about backwards compatibility if you change this
        /// </summary>
        /// <value>
        /// The message identifier.
        /// </value>
        [DataMember(Name = nameof(ConversationPayloadFields.msgId), IsRequired = true)]
        public string MessageId
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the group.
        /// </summary>
        /// <value>
        /// The group.
        /// </value>
        [DataMember(Name = nameof(ConversationPayloadFields.group), IsRequired = true)]
        public string Group
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets from.
        /// </summary>
        /// <value>
        /// From string
        /// </value>
        [DataMember(Name = nameof(ConversationPayloadFields.from), IsRequired = true)]
        public string From { get; set; }

        /// <summary>
        /// Gets or sets the preview.
        /// </summary>
        /// <value>
        /// The preview.
        /// </value>
        [DataMember(Name = nameof(ConversationPayloadFields.preview), IsRequired = true)]
        public string Preview
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the delivery time.
        /// </summary>
        /// <value>
        /// The delivery time.
        /// </value>
        [DataMember(Name = nameof(ConversationPayloadFields.deliveryTime), IsRequired = true)]
        public string DeliveryTime
        {
            get;
            set;
        }
    }
}
