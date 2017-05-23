namespace ExampleCodeLibraryTests.TestLists
{
    internal class VehicleAccelerateExceptionsList : TestListBase
    {
        public VehicleAccelerateExceptionsList()
        {
            Testlist.Add(new object[] { 0m, "Zero is not an accpeted value" });
            Testlist.Add(new object[] { -0.01m, "Only positive numbers are accepted" });
        }
    }
}
