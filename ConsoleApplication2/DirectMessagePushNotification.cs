// ------------------------------------------------------------------------------
// <summary>File for the DirectMessagePushNotification class.</summary>
// <copyright file="DirectMessagePushNotification.cs" company="Microsoft">
//     Copyright (c) Microsoft Corporation.  All rights reserved.
// </copyright>                         
// ------------------------------------------------------------------------------               
namespace Microsoft.OutlookApps.Groupies.GroupiesApi.DataContracts
{
    using System.Runtime.Serialization;

    /// <summary>
    /// The implementation of DirectMessagePushNotification.
    /// </summary>
    [DataContract(Name = "dm")]
    public class DirectMessagePushNotification
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DirectMessagePushNotification"/> class.
        /// </summary>
        public DirectMessagePushNotification()
        {
            this.ConversationId = string.Empty;
            this.Notification = string.Empty;
        }

        /// <summary>
        /// Gets or sets the notification.
        /// </summary>
        /// <value>
        /// The notification.
        /// </value>
        [DataMember(Name = "n")]
        public string Notification
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the conversation identifier.
        /// </summary>
        /// <value>
        /// The conversation identifier.
        /// </value>
        [DataMember(Name = "cId")]
        public string ConversationId
        {
            get;
            set;
        }
    }
}
