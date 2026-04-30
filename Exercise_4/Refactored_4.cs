using System;
public interface IClickable
{
    void OnClick();
}
public interface IHoverable
{
    void OnHover();
}
public interface IDragable
{
    void OnDrag();
}
public class InventoryButton : IClickable, IHoverable
{
    public void OnClick()
    {
        Console.WriteLine("Inventory button clicked");
    }

    public void OnHover()
    {
        Console.WriteLine("Inventory button hover");
    }
}

public class InventoryItemSlot : IHoverable, IDragable
{
    public void OnHover()
    {
        Console.WriteLine("Item slot hover");
    }

    public void OnDrag()
    {
        Console.WriteLine("Dragging item slot");
    }
}
