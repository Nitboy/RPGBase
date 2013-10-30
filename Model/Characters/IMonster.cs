namespace Model
{
    public interface IMonster : ICharacter
    {
        IEvent MonsterAction();
    }
}