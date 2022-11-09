

   
    {
        byte jop = 250;
        try
        {
            student one = new student("Иванов", "Коля", checked((byte) (jop+60)));
            Console.WriteLine(one);
        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
            throw;
        }
      


    //    byte c = 200;
    //    byte w = 100;
    //    try
    //    {
    //        //int d = 4;
    //        //int y = 0;
    //        //int p = d / y;
           
    //        byte po = (checked((byte)(c + w)));
    //    }
    //    catch (Exception yu)
    //    {
    //       Console.WriteLine(yu.Message);
    //        throw;
    //    }
    }

