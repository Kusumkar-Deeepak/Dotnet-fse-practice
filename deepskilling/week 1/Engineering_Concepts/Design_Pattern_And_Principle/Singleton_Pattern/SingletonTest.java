public class SingletonTest
{
    public static void main(String[] args)
    {
        Logger logger1 = Logger.getInstance();

        Logger logger2 = Logger.getInstance();

        logger1.log("Application Started");

        logger2.log("User Logged In");

        System.out.println();

        System.out.println(
            "Are both objects same? "
            + (logger1 == logger2)
        );
    }
}