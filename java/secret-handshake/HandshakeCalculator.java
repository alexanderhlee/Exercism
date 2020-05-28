import java.util.ArrayList;
import java.util.Arrays;
import java.util.Collections;
import java.util.List;

class HandshakeCalculator {

    List<Signal> calculateHandshake(int number) {
        ArrayList<Signal> retList = new ArrayList();

        Signal[] a = Signal.values();
        if (number >= 16) {
            Collections.reverse(Arrays.asList(a));
        }

        for (Signal sig : a) {
            int bitTest = (int)Math.pow(2, sig.ordinal());

            if ((number & bitTest) > 0) {
                retList.add(sig);
            }
        }

        return retList;
    }
}