﻿using System;
using System.Runtime.InteropServices;
using System.Threading.Tasks;

#pragma warning disable 0067

namespace DesktopNotifications.Apple
{
    public class AppleNotificationManager : INotificationManager
    {
        [DllImport("DesktopNotifications.Apple.Native.dylib")]
        private static extern void ShowNotification();

        public void Dispose()
        {
        }

        public event EventHandler<NotificationActivatedEventArgs>? NotificationActivated;
        public event EventHandler<NotificationDismissedEventArgs>? NotificationDismissed;

        public string? LaunchActionId { get; }

        public ValueTask Initialize()
        {
            return default;
        }

        public ValueTask ShowNotification(Notification notification, DateTimeOffset? expirationTime = null)
        {
            ShowNotification();

            return default;
        }

        public ValueTask ScheduleNotification(Notification notification, DateTimeOffset deliveryTime,
            DateTimeOffset? expirationTime = null)
        {
            return default;
        }
    }
}
