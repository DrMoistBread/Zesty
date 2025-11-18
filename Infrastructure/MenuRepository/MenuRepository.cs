using Domain.MenuAggregate;
using Domain.MenuAggregate.Interfaces;
using Domain.Menus.ValueObjects;

namespace Infrastructure.MenuRepository;

public class MenuRepository : IMenuRepository
{
    private List<Menu> _menus = new List<Menu>();
    public List<Menu> ListAll()
    {
        return _menus;
    }

    public Menu? Find(MenuId menuId)
    {
        return _menus.FirstOrDefault(x => x.Id == menuId);
    }

    public void Add(Menu menu)
    {
       _menus.Add(menu);
    }

    public void Update(Menu menu)
    {
        throw new NotImplementedException();
    }

    public void Delete(MenuId menu)
    {
        throw new NotImplementedException();
    }
}