﻿namespace Electrimax.Orders.Application;

public sealed record OrderResponse(
    Guid Id,
    string CustomerId,
    string CustomerName,
    DateTime CreatedAt,
    decimal SubTotal,
    decimal Total,
    decimal Discount,
    IReadOnlyCollection<OrderItemResponse> Items
);
