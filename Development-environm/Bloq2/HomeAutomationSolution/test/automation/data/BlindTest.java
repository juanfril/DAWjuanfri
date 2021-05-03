package automation.data;

import org.junit.jupiter.api.BeforeEach;
import org.junit.jupiter.api.Test;

import static org.junit.jupiter.api.Assertions.*;

class BlindTest {
    Blind b;
    @BeforeEach
    void setUp(){
        b = new Blind("probe", 100);
    }

    @Test
    void raise() {
        b.raise();
        assertEquals(b.getPercent(), 100);
    }

    @Test
    void testRaise() {
        b.raise(50);
        assertEquals(b.getPercent(), 100);
        b.raise(-150);
        assertEquals(b.getPercent(), -50);
        b.raise(250);
        assertEquals(b.getPercent(), 100);
    }

    @Test
    void lower() {
        b.lower();
        assertEquals(b.getPercent(), 0);
    }

    @Test
    void testLower() {
        b.lower(50);
        assertEquals(b.getPercent(), 50);
        b.lower(-150);
        assertEquals(b.getPercent(), 200);
        b.lower(250);
        assertEquals(b.getPercent(), 0);
    }

    @Test
    void getPercent() {
        assertEquals(b.getPercent(), 100);
    }

    @Test
    void testToString() {
        String expected = "- probe: 100%";
        assertEquals(expected, b.toString());
    }
}