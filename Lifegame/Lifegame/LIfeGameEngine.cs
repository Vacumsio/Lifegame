namespace Lifegame
{
    public static class LifeGameEngine
    {
        public static Field GetNextGeneration(Field currentField)
        {
            var resultField = new Field(currentField.Rows, currentField.Cols);


            return resultField;
        }
    }
}
