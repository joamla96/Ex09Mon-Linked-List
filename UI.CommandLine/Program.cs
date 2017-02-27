using System;
using LinkedList;

namespace UI.CommandLine {
	class Program {
		static void Main(string[] args) {
			Program program = new Program();
			program.Run();
		}

		private void Run() {
			MyList List = new MyList();
			ClubMember CM1 = new ClubMember(1, "John", "Doe", 20);
			ClubMember CM2 = new ClubMember(2, "Jane", "Doe", 22);
			ClubMember CM3 = new ClubMember(3, "Rox", "Ion", 22);
			ClubMember CM4 = new ClubMember(4, "Jhones", "Laurs", 21);

			List.Insert(CM1);
			List.Insert(CM2);
			List.Insert(CM3);
			List.Insert(CM4);

			Console.WriteLine(List.ToString());

			List.Delete();
			List.Delete();
			List.Delete();
			List.Delete();

			Console.ReadKey();
		}

	}
}
