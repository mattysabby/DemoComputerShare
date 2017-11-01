using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DemoComputerShare.OptionalSelection;

namespace DemoComputerShare
{

    public class OptionInvoker
    {
        private List<ISelectionOption> selectionOptions;

        public OptionInvoker()
        {
            selectionOptions = new List<ISelectionOption>();
            selectionOptions.Add(new GetAllRecords());
            selectionOptions.Add(new AddRecord());
            selectionOptions.Add(new DeleteEmployee());
        }

        public ISelectionOption GetSelectionOption(SelectionEnum selection)
        {
            foreach (var option in selectionOptions)
            {
                if (option.Option == selection)
                {
                    return option;
                }
            }
            return null;

        }

        public void DisplayOption()
        {
            Console.WriteLine("Select An option");
            foreach (var option in selectionOptions)
            {
                string description = EnumHelper<SelectionEnum>.GetEnumDescription(option.Option.ToString());
                Console.WriteLine($"Enter number {(int)option.Option} to {description}");
            }
        }
    }
}
