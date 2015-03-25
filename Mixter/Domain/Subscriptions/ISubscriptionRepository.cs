using System.Collections.Generic;

namespace Mixter.Domain.Subscriptions
{
    public interface ISubscriptionRepository
    {
        //todo: on ne doit pas retourn�e des userId dans le subscriptionRepo!!!!!!!!
        IEnumerable<UserId> GetFollowers(UserId userId);
    }
}