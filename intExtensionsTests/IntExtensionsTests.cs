using Xunit;
using System;

namespace intExtensionsTests
{
    public class IntExtensionsTests
    {
        [Fact]
        public void IntExtensionsTests_Success()
        {

            Assert.Equal("����", ((long)5).ToWords());
            Assert.Equal("������", ((long)10).ToWords());
            Assert.Equal("������������", ((long)19).ToWords());
            Assert.Equal("��� ����������", ((long)115).ToWords());
            Assert.Equal("������ �����", ((long)240).ToWords());
            Assert.Equal("������� ����", ((long)505).ToWords());
            Assert.Equal("������ ����� ������", ((long)248).ToWords());
            Assert.Equal("������� ����� ����", ((long)547).ToWords());
            Assert.Equal("��������� ��������� ������", ((long)999).ToWords());
            Assert.Equal("���� ������", ((long)1_000).ToWords());
            Assert.Equal("���� ������ ����", ((long)1_001).ToWords());
            Assert.Equal("���� ������ �����������", ((long)1_011).ToWords());
            Assert.Equal("���� ������ ������������", ((long)1_019).ToWords());
            Assert.Equal("��� ������ ����������", ((long)2_013).ToWords());
            Assert.Equal("��� ������ �������� ����", ((long)2_027).ToWords());
            Assert.Equal("��� ������ ��� �������� ����", ((long)2_135).ToWords());
            Assert.Equal("����������� ����� ��� �������� ������", ((long)11_134).ToWords());
            Assert.Equal("����������� ����� �����������", ((long)12_012).ToWords());
            Assert.Equal("������������ ����� ������� ����������� ���", ((long)19_582).ToWords());
            Assert.Equal("�������� ���� ������ ������", ((long)21_300).ToWords());
            Assert.Equal("������� �����", ((long)500_000).ToWords());
            Assert.Equal("������ ����������� ����� ��������� ����� ������", ((long)311_844).ToWords());
            Assert.Equal("������� ����� ������ ����� ������� ��������� ���", ((long)548_773).ToWords());
            Assert.Equal("��������� ������������ ����� �������� �����������", ((long)919_611).ToWords());
            Assert.Equal("��������� ����� ��� ������ ����������� ����", ((long)843_085).ToWords());
            Assert.Equal("���� �������", ((long)1_000_000).ToWords());
            Assert.Equal("���� ������� ����", ((long)1_000_005).ToWords());
            Assert.Equal("���� ������� ����������", ((long)1_000_015).ToWords());
            Assert.Equal("���� ������� ����������� ����� �������� ����", ((long)1_011_021).ToWords());
            Assert.Equal("���������� ��������� ������� �����", ((long)17_700_000).ToWords());
            Assert.Equal("�������� ���� ������� ������ ��������� ����� �������� ������", ((long)21_250_029).ToWords());
            Assert.Equal("��� ���������� ��������� �������� ����������� ����� ��������� ������", ((long)117_611_808).ToWords());
            Assert.Equal("������� �������� ���� ��������� ��������� ����������� ����� ��� ������������", ((long)537_911_119).ToWords());
            Assert.Equal("���� ��������", ((long)1_000_000_000).ToWords());
            Assert.Equal("���� �������� ������", ((long)1_000_000_010).ToWords());
            Assert.Equal("���� �������� ������ �����", ((long)1_000_300_000).ToWords());
            Assert.Equal("���� �������� ������ ����� ������", ((long)1_000_300_200).ToWords());
            Assert.Equal("���� �������� ������ ����� ������ �������� ������", ((long)1_000_300_228).ToWords());
            Assert.Equal("���� �������� ����������� ��������� ������ ����� ������ ����� �����", ((long)1_012_300_246).ToWords());
            Assert.Equal("������� ����� ���������� ������� ����������� ��������� ��������� ����� ��� ������ ����������� ����", 740_512_843_085.ToWords());
            Assert.Equal("������ ������������� ������ �������� ��� ������������ ������ ��������� ��� ��������� �������� ����� ���������� ��������� ��������� ������ �������� ������� ��������� ���� ����� ��������� ����", 9_223_372_036_854_775_807.ToWords());
            
        }
    }
}