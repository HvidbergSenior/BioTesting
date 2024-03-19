using BioFuelExpress.BuildingBlocks.Domain;

namespace BioFuelExpress.BuildingBlocks.Events
{
    public interface IEntityEventsPublisher
    {
        IReadOnlyCollection<IDomainEvent> EnqueueEventsFrom(Entity entity);

        bool TryEnqueueEventsFrom(Entity entity, out IReadOnlyCollection<IDomainEvent> uncomittedEvents);

        Task Publish(CancellationToken cancellationToken = default);
    }
}