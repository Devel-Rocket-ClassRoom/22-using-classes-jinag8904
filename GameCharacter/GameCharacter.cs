using System;
using System.Net.Security;

public class GameCharacter
{
    string Name;
    int Level;
    int MaxHP => Level * 100;
    int CurrentHP;
    int AttackPower => Level * 10;
    bool IsAlive => (CurrentHP > 0);

    public GameCharacter(string name, int level)
    {
        Name = name;
        Level = level;
        CurrentHP = MaxHP;
    }

    public void Attack(GameCharacter target)
    {
        target.TakeDamage(this.AttackPower);
        Console.WriteLine($"{this.Name}이(가) {target.Name}에게 {this.AttackPower} 데미지를 입혔습니다!");
    }

    public void TakeDamage(int damage)
    {
        CurrentHP -= damage;
    }

    public void ShowStatus()
    {
        Console.WriteLine($"[{Name}] Lv.{Level} - HP: {CurrentHP}/{MaxHP}, 공격력: {AttackPower}");
    }
}