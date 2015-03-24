<?php
require_once("../src/NifSpain.php");

class NifSpainTest extends PHPUnit_Framework_TestCase {

    public function testGetLetter()
    {
        $nifSpain = new NifSpain();

        $this->assertEquals("B", $nifSpain->getLetter(12332358));
        $this->assertEquals("L", $nifSpain->getLetter(12311919));
        $this->assertNotEquals("L", $nifSpain->getLetter(12311911));
        $this->assertEquals("B", $nifSpain->getLetter("12332358"));

    }

}
