namespace CaliburnMicroBindToDoubleFormattingTest {
    public class ShellViewModel : Caliburn.Micro.PropertyChangedBase, IShell
    {
        public double BoundByName { get; set; }
        public double BoundByPathWorksAsBoundByName { get; set; }
        public double BoundByPath { get; set; }
        public double BoundByPathWithFormatting { get; set; }
    }
}