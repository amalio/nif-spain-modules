import org.junit.Test;
import org.junit.runner.RunWith;
import org.junit.runners.Parameterized;

import java.util.Arrays;
import java.util.Collection;

import static org.junit.Assert.assertEquals;
import static org.junit.Assert.assertNotEquals;

@RunWith(Parameterized.class)
public class CheckTest {




    @Parameterized.Parameters
    public static Collection<Object[]> data() {
        return Arrays.asList(new Object[][]{

                {true, "12332358B"},
                {true, "12311919L"},
                {false,"12332359L"},
                {false,"12311911C"},
                {false,"12"},
                {false,"123323581"}

        });
    }

    @Parameterized.Parameter
    public boolean expected;

    @Parameterized.Parameter (value = 1)
    public String nif;


    @Test
    public void test()  {

        NifSpain nifSpain = new NifSpain();


       assertEquals(expected, nifSpain.check(nif));

    }




}
