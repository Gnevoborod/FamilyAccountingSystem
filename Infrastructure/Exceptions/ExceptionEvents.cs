namespace FamilyAccountingSystem.Infrastructure.Exceptions
{
    public static class ExceptionEvents
    {

        public static readonly EventId UserIdUndefined = new EventId(100, "Пользователь не определён по id");
    }
}
