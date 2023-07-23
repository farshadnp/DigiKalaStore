using Hangfire;
using Hangfire.Annotations;
using Hangfire.Common;

namespace DigiKala.WebAPI._03.Shared.Utils.HangFire
{
    public class HangfireConfig : IRecurringJobManager
    {
        
        public void AddOrUpdate([NotNull] string recurringJobId, [NotNull] Job job, [NotNull] string cronExpression, [NotNull] RecurringJobOptions options)
        {
            
            //job.AddOrUpdate<WelcomeBonusUtil>("RetakeWelcomeBonus", x => x.RemoveCerditJob(), Configuration["WelcomeBonus:WelcomeBonusJobInHours"]);
            
        }

        public void RemoveIfExists([NotNull] string recurringJobId)
        {
            throw new NotImplementedException();
        }

        public void Trigger([NotNull] string recurringJobId)
        {
            throw new NotImplementedException();
        }

        
    }
}
