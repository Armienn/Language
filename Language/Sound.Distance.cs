using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Language {
	public partial struct Sound {
		public double Distance(Sound other) {
			double airstreamdist;
			double initiationdist;
			//if(LabialArticulation
			return 0;
		}

		public static double Distance(Sound one, Sound two) {
			return one.Distance(two);
		}

		public int PlacesOfArticulation {
			get {
				int n = 0;
				if (LabialArticulation.Point != ObstructionPoint.None)
					n++;
				if (CoronalArticulation.Point != ObstructionPoint.None)
					n++;
				if (DorsalArticulation.Point != ObstructionPoint.None)
					n++;
				if (RadicalArticulation.Point != ObstructionPoint.None)
					n++;
				return n;
			}
		}
	}
}
