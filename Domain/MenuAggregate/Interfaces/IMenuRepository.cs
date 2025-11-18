using Domain.Menus.ValueObjects;

namespace Domain.MenuAggregate.Interfaces;

public interface IMenuRepository
{
    List<Menu> ListAll();
    Menu? Find(MenuId menuId);
    void Add(Menu menu);
    void Update(Menu menu);
    void Delete(MenuId menu);
}