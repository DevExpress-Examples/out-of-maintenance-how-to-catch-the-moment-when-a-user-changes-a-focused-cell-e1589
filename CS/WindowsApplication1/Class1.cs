using System;

namespace WindowsApplication1 {
	public class Record {
		private int fID;
		private string fProductName;
		private string fCategory;
		private bool fDiscontinued;
		private double fUnitPrice;
        private int fA;
        private int fB;
        private int fC;
        private int fD;
        private int fE;
        private int fF;
        private int fG;
        private int fH;
        private int fI;
        private int fJ;

		public Record(int fID, string fProductName, string fCategory, bool fDiscontinued, double fUnitPrice) {
			this.fID = fID;
			this.fProductName = fProductName;
			this.fCategory = fCategory;
			this.fDiscontinued = fDiscontinued;
			this.fUnitPrice = fUnitPrice;
		}

		public int ID {
			get { return fID; }
		}

		public string ProductName {
			get { return fProductName; }
			set { fProductName = value; }
		}

		public string Category {
			get { return fCategory; }
			set { fCategory = value; }
		}

		public bool Discontinued {
			get { return fDiscontinued; }
			set { fDiscontinued = value; }
		}

		public double UnitPrice {
			get { return fUnitPrice; }
			set { fUnitPrice = value; }
		}

        public int A{
            get { return fA; }
            set { fA = value; }
        }
        public int B{
            get { return fB; }
            set { fB = value; }
        }
        public int C{
            get { return fC; }
            set { fC = value; }
        }
        public int D{
            get { return fD; }
            set { fD = value; }
        }
        public int E{
            get { return fE; }
            set { fE = value; }
        }
        public int F{
            get { return fF; }
            set { fF = value; }
        }

        public int G{
            get { return fG; }
            set { fF = value; }
        }

        public int H{
            get { return fF; }
            set { fF = value; }
        }

        public int I{
            get { return fF; }
            set { fF = value; }
        }
        public int J{
            get { return fF; }
            set { fF = value; }
        }
    }
}
