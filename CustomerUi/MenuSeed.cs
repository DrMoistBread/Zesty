using Domain.Common;
using Domain.MenuAggregate;
using Domain.MenuAggregate.Interfaces;
using Domain.Menus.Entities;
using Domain.Menus.ValueObjects;
using Infrastructure.MenuRepository;

namespace CustomerUi;

public class MenuSeed
{
    private readonly IMenuRepository _menuRepository;
    
    public MenuSeed(IMenuRepository menuRepository)
    {
        _menuRepository = menuRepository;
    }

    public void Seed()
    {
        var menu1 = Menu.Create("Menu do dia");
        var menu2 = Menu.Create("Menu da noite");
        var menu3 = Menu.Create("Carta de Vinhos");

        var MenuItem1 = MenuItem.Create(
            "Picado de Vaca",
            "Carne de Vaca, Batata Frite, Cogumelhos, Natas",
            Price.Create(15, "EUR"),
            MenuItemType.Kitchen);

        var MenuItem2 = MenuItem.Create(
            "Francesinha",
            "Carne de Vaca, Bacon, Salsicha, Batata frita, Tomate",
            Price.Create(12.50f, "EUR"),
            MenuItemType.Kitchen);
        
        var MenuItem3 = MenuItem.Create(
            "Lasanha de Atum",
            "Atum, Massa, azeitonas, cogumelhos, Natas",
            Price.Create(10f, "EUR"),
            MenuItemType.Kitchen);
        
        menu1.Add(MenuItem1);
        menu1.Add(MenuItem2);
        menu1.Add(MenuItem3);
        
        var MenuItem4 = MenuItem.Create(
            "Sopa de trigo",
            "trigo, cenas, carne",
            Price.Create(8, "EUR"),
            MenuItemType.Kitchen);

        var MenuItem5 = MenuItem.Create(
            "Taggliatelle de camarão",
            "Taggliatelle, camarão, alho, pesto",
            Price.Create(12f, "EUR"),
            MenuItemType.Kitchen);
        
        var MenuItem6 = MenuItem.Create(
            "Cozido à portuguesa",
            "Carne de Vaca, Carne de Porco, Frango, Enchidos, Couve, Batata Cozida, Batata Doce",
            Price.Create(15f, "EUR"),
            MenuItemType.Kitchen);
        
        menu2.Add(MenuItem4);
        menu2.Add(MenuItem5);
        menu2.Add(MenuItem6);
        
        var MenuItem7 = MenuItem.Create(
            "Quinta nova (UnOaked)",
            "",
            Price.Create(25, "EUR"),
            MenuItemType.Bar);

        var MenuItem8 = MenuItem.Create(
            "Rocim - Reserva",
            "",
            Price.Create(20f, "EUR"),
            MenuItemType.Bar);
        
        var MenuItem9 = MenuItem.Create(
            "Duas Quintas",
            "",
            Price.Create(22f, "EUR"),
            MenuItemType.Bar);
        
        menu3.Add(MenuItem7);
        menu3.Add(MenuItem8);
        menu3.Add(MenuItem9);
        
        _menuRepository.Add(menu1);
        _menuRepository.Add(menu2);
        _menuRepository.Add(menu3);
    }
}