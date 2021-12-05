using Xunit;
using System;

namespace intExtensionsTests
{
    public class IntExtensionsTests
    {
        [Fact]
        public void IntExtensionsTests_Success()
        {

            Assert.Equal("пять", ((long)5).ToWords());
            Assert.Equal("десять", ((long)10).ToWords());
            Assert.Equal("девятнадцать", ((long)19).ToWords());
            Assert.Equal("сто пятнадцать", ((long)115).ToWords());
            Assert.Equal("двести сорок", ((long)240).ToWords());
            Assert.Equal("пятьсот пять", ((long)505).ToWords());
            Assert.Equal("двести сорок восемь", ((long)248).ToWords());
            Assert.Equal("пятьсот сорок семь", ((long)547).ToWords());
            Assert.Equal("девятьсот девяносто девять", ((long)999).ToWords());
            Assert.Equal("одна тысяча", ((long)1_000).ToWords());
            Assert.Equal("одна тысяча один", ((long)1_001).ToWords());
            Assert.Equal("одна тысяча одиннадцать", ((long)1_011).ToWords());
            Assert.Equal("одна тысяча девятнадцать", ((long)1_019).ToWords());
            Assert.Equal("две тысячи тринадцать", ((long)2_013).ToWords());
            Assert.Equal("две тысячи двадцать семь", ((long)2_027).ToWords());
            Assert.Equal("две тысячи сто тридцать пять", ((long)2_135).ToWords());
            Assert.Equal("одиннадцать тысяч сто тридцать четыре", ((long)11_134).ToWords());
            Assert.Equal("двеннадцать тысяч двеннадцать", ((long)12_012).ToWords());
            Assert.Equal("девятнадцать тысяч пятьсот восемьдесят два", ((long)19_582).ToWords());
            Assert.Equal("двадцать одна тысяча триста", ((long)21_300).ToWords());
            Assert.Equal("пятьсот тысяч", ((long)500_000).ToWords());
            Assert.Equal("триста одиннадцать тысяч восемьсот сорок четыре", ((long)311_844).ToWords());
            Assert.Equal("пятьсот сорок восемь тысяч семьсот семьдесят три", ((long)548_773).ToWords());
            Assert.Equal("девятьсот девятнадцать тысяч шестьсот одиннадцать", ((long)919_611).ToWords());
            Assert.Equal("восемьсот сорок три тысячи восемьдесят пять", ((long)843_085).ToWords());
            Assert.Equal("один миллион", ((long)1_000_000).ToWords());
            Assert.Equal("один миллион пять", ((long)1_000_005).ToWords());
            Assert.Equal("один миллион пятнадцать", ((long)1_000_015).ToWords());
            Assert.Equal("один миллион одиннадцать тысяч двадцать один", ((long)1_011_021).ToWords());
            Assert.Equal("семнадцать миллионов семьсот тысяч", ((long)17_700_000).ToWords());
            Assert.Equal("двадцать один миллион двести пятьдесят тысяч двадцать девять", ((long)21_250_029).ToWords());
            Assert.Equal("сто семнадцать миллионов шестьсот одиннадцать тысяч восемьсот восемь", ((long)117_611_808).ToWords());
            Assert.Equal("пятьсот тридцать семь миллионов девятьсот одиннадцать тысяч сто девятнадцать", ((long)537_911_119).ToWords());
            Assert.Equal("один миллиард", ((long)1_000_000_000).ToWords());
            Assert.Equal("один миллиард десять", ((long)1_000_000_010).ToWords());
            Assert.Equal("один миллиард триста тысяч", ((long)1_000_300_000).ToWords());
            Assert.Equal("один миллиард триста тысяч двести", ((long)1_000_300_200).ToWords());
            Assert.Equal("один миллиард триста тысяч двести двадцать восемь", ((long)1_000_300_228).ToWords());
            Assert.Equal("один миллиард двеннадцать миллионов триста тысяч двести сорок шесть", ((long)1_012_300_246).ToWords());
            Assert.Equal("семьсот сорок миллиардов пятьсот двеннадцать миллионов восемьсот сорок три тысячи восемьдесят пять", 740_512_843_085.ToWords());
            Assert.Equal("девять квинтиллионов двести двадцать три квадриллиона триста семьдесят два триллиона тридцать шесть миллиардов восемьсот пятьдесят четыре миллиона семьсот семьдесят пять тысяч восемьсот семь", 9_223_372_036_854_775_807.ToWords());
            
        }
    }
}