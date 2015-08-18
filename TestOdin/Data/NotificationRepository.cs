using System.Collections.Generic;
using TestOdin.Models;

namespace TestOdin.Data
{
    public class NotificationRepository : RepositoryBase<Notification>
    {
        public NotificationRepository(IEnumerable<Notification> notify)
            :base(notify)
        {

        }
    }
}