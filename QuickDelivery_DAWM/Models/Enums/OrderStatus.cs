namespace QuickDelivery_DAWM.Models.Enums
{
    public enum OrderStatus
    {
        Pending = 1,
        Confirmed = 2,
        Preparing = 3,
        ReadyForPickup = 4,
        InTransit = 5,
        Delivered = 6,
        Cancelled = 7,
        Refunded = 8
    }
}