import org.junit.Test;
import org.junit.runner.RunWith;
import org.junit.runners.Parameterized;

import java.util.Arrays;
import java.util.Collection;

import static org.junit.Assert.assertEquals;
import static org.junit.Assert.assertNotEquals;

@RunWith(Parameterized.class)
public class GetLetterTest {




    @Parameterized.Parameters
    public static Collection<Object[]> data() {
        return Arrays.asList(new Object[][]{

                {true, 'B', 12332358},
                {true, 'L', 12311919},
                {false, 'B', 12332359},
                {false, 'L', 12311911},

        });
    }

    @Parameterized.Parameter
    public boolean equalAssertion;

    @Parameterized.Parameter (value = 1)
    public char expected;

    @Parameterized.Parameter (value = 2)
    public int numbers;


    @Test
    public void test()  {

        NifSpain nifSpain = new NifSpain();

        if (equalAssertion)
            assertEquals(expected, nifSpain.getLetter(numbers));
        else
            assertNotEquals(expected, nifSpain.getLetter(numbers));
    }




}
