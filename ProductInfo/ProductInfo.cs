using System;

class ProductInfo
{
    string Name;
    int Price;
    public double DiscountPercent;
    double DiscountAmount => (DiscountPercent / 100) * Price;
    double FInalPrice => Price - DiscountAmount;

    public ProductInfo(string name, int price)
    {
        Name = name;
        Price = price;
        DiscountPercent = 0;
    }

    public ProductInfo(string name, int price, int discountPercent)
    {
        Name = name;
        Price = price;
        DiscountPercent = discountPercent;
    }

    public void PrintInfo()
    {
        Console.WriteLine($"[상품 정보] {Name} - 가격: {Price}원, 할인: {DiscountPercent}% (-{DiscountAmount}원), 최종가: {FInalPrice}원");
    }
}