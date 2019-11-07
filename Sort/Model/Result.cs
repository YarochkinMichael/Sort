namespace Sort.Model
{
    public struct Result
    {
        string message;
        bool status;

        public static Result OK(string message)
        {
            Result result = new Result();
            result.status = true;
            result.message = message;

            return result;
        }

        public static Result Failed(string message)
        {
            Result result = new Result();
            result.status = false;
            result.message = message;

            return result;
        }
    }
}