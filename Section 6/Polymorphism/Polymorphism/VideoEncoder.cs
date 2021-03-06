﻿using System.Collections.Generic;

namespace Polymorphism
{
    public class VideoEncoder
    {
        private readonly IList<INotificationChannel> notificationChannels;

        public VideoEncoder()
        {
            notificationChannels = new List<INotificationChannel>();
        }

        public void Encode(Video video)
        {
            //code

            foreach (var channel in notificationChannels)
            {
                channel.Send(new Message());
            }
        }

        public void RegisterNotificationChannel(INotificationChannel channel)
        {
            notificationChannels.Add(channel);
        }
    }
}