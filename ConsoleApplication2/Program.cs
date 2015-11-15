using Microsoft.OutlookApps.Groupies.GroupiesApi.DataContracts;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Json;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class Program
    {
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
            /// The conv identifier
            /// </summary>
            convId,
        }

        static void Main(string[] args)
        {
            GroupPushNotification p = new GroupPushNotification();

            MemoryStream stream1 = new MemoryStream();
            DataContractJsonSerializer ser = new DataContractJsonSerializer(typeof(GroupPushNotification));
            ser.WriteObject(stream1, p);

            var sw = new StreamReader(stream1);
            stream1.Position = 0;
            var s = sw.ReadToEnd();
            string jsondmPayloadProperty = JsonConvert.SerializeObject(s);
            Console.WriteLine(jsondmPayloadProperty);
            
            Console.WriteLine(nameof(ConversationPayloadFields.msgId));
            string x = s;
        }
    }
}
