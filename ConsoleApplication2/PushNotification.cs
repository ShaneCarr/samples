// ------------------------------------------------------------------------------
// <summary>File for the PushNotification class.</summary>
// <copyright file="PushNotification.cs" company="Microsoft">
//     Copyright (c) Microsoft Corporation.  All rights reserved.
// </copyright>                         
// ------------------------------------------------------------------------------               
namespace Microsoft.OutlookApps.Groupies.GroupiesApi.DataContracts
{
    using System.Runtime.Serialization;

    /// <summary>
    /// Implements a class for PushNotification
    /// TODO note it would be cool if all the phone has the same exact type and we
    /// handled the special case stuff on the phone particularly for the header.
    /// or doing a chain of responsibility for the different platforms would be great.
    /// </summary>
    [DataContract]
    public class PushNotification
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PushNotification"/> class.
        /// </summary>
        public PushNotification()
        {
            this.GroupNotification = new GroupPushNotification();
            this.DirectMessageNotification = new DirectMessagePushNotification();
        }

        /// <summary>
        /// Gets or sets the group notification.
        /// </summary>
        /// <value>
        /// The group notification.
        /// </value>
        [DataMember(Name = "n", IsRequired = true)]
        public GroupPushNotification GroupNotification
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the direct message notification.
        /// </summary>
        /// <value>
        /// The direct message notification.
        /// </value>
        [DataMember(Name = "dm", IsRequired = true)]
        public DirectMessagePushNotification DirectMessageNotification
        {
            get;
            set;
        }
    }
}
