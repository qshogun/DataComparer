using DataComparerMVVM.Core;
using DataComparerMVVM.MVVM.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataComparerMVVM.MVVM.ViewModel
{
    class CompareViewModel : ObservableObject
    {
        private ObservableCollection<Segment> _segments;
        private Segment _segment;

        public ObservableCollection<Segment> Segments
        {
            get { return _segments; }
            set { _segments = value; }
        }

        public Segment SelectedSegment
        {
            get { return _segment; }
            set { _segment = value; }
        }

        public CompareViewModel()
        {
            Segments = new ObservableCollection<Segment>()
            {
                new Segment(){ Id = 1, Name = "Segment 1" },
                new Segment(){ Id = 2, Name = "Segment 2" },
                new Segment(){ Id = 3, Name = "Segment 3" }
            };
        }
    }
}