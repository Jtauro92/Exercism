abstract class Character
{
    private string _characterType;
    protected Character(string characterType)
    {
        this._characterType = characterType;
    }

    public abstract int DamagePoints(Character target);

    public virtual bool Vulnerable()
    {
        return false;
    }

    public override string ToString()
    {
        return $"Character is a {this._characterType}";
    }
}

class Warrior : Character
{
    public Warrior() : base("Warrior")
    {
    }

    public override int DamagePoints(Character target)
    {
        if(target.Vulnerable())
        {
            return 10;
        }
        return 6;
    }
}

class Wizard : Character
{
    private bool _spellPrepared = false;
    public Wizard() : base("Wizard")
    {
    }
    public override bool Vulnerable()
    {
        return !this._spellPrepared;
    }
    public override int DamagePoints(Character target)
    {
        if (this._spellPrepared)
        {
            return 12;
        }
        return 3;
    }

    public void PrepareSpell()
    {
        this._spellPrepared = true;
    }
}
