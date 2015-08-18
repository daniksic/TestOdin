using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TestOdin.Models;

namespace TestOdin.Data
{
    public sealed class UoW
    {
        private static readonly UoW _instance = new UoW();
        private IEnumerable<Task> _tasks;
        private IEnumerable<Notification> _notifications;

        private UoW()  {
            _tasks = new List<Task>
            {
                new Task { Id=1, Name="Task 1" , DateAdded = DateTime.Now.AddHours(-2)},
                new Task { Id=2, Name="Task 2" , DateAdded = DateTime.Now.AddHours(-1)}
            };

            _notifications = new List<Notification>
            {
                new Notification { Id=1, Name="Notify 1", DateAdded = DateTime.Now.AddHours(1) },
                new Notification { Id=2, Name="Notify 2", DateAdded = DateTime.Now.AddHours(2) }
            };
        }

        public static UoW Instance()
        {
            return _instance;
        }

        public IRepository<Task> Tasks()
        {
            return new TaskRepository(_tasks);
        }

        public IRepository<Notification> Notifications()
        {
            return new NotificationRepository(_notifications);
        }
    }
}
