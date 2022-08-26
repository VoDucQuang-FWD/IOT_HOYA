using Hoya.Model;
using Hoya.View;
using IOT.Class;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;
using System.Windows.Threading;
using static Hoya.ViewModel.MainViewModel;

namespace Hoya.ViewModel
{
    public class DBHOYAViewModel : BaseViewModel
    {
        int model = 1;
        #region khai bao
        DateTime _SelectDatetimes;
        public DateTime SelectDatetimes
        {
            get { return _SelectDatetimes; }
            set { SetProperty(ref _SelectDatetimes, value, nameof(SelectDatetimes)); }
        }

        private string _day;
        public string day
        {
            get => _day;
            set => _ = SetProperty(ref _day, value, nameof(day));
        }
        string _month;
        public string month
        {
            get { return _month; }
            set { SetProperty(ref _month, value, nameof(month)); }
        }
        string _year;
        public string year
        {
            get { return _year; }
            set { SetProperty(ref _year, value, nameof(year)); }
        }
        DateTime _timetoday;
        public DateTime timetoday
        {
            get { return _timetoday; }
            set { SetProperty(ref _timetoday, value, nameof(timetoday)); }
        }

        DateTime _timelasttoday;
        public DateTime timelasttoday
        {
            get { return _timelasttoday; }
            set { SetProperty(ref _timelasttoday, value, nameof(timelasttoday)); }
        }

        int _Qtytoday;
        public int Qtytoday
        {
            get { return _Qtytoday; }
            set { SetProperty(ref _Qtytoday, value, nameof(Qtytoday)); }
        }
        string _SelectBasket;
        public string SelectBasket
        {
            get { return _SelectBasket; }
            set
            {
                SetProperty(ref _SelectBasket, value, nameof(SelectBasket));
            }
        }
        public ObservableCollection<OrderStatus> _WoringTime;
        public ObservableCollection<OrderStatus> WoringTime
        {
            get { return _WoringTime; }
            set
            {
                SetProperty(ref _WoringTime, value, nameof(WoringTime));
            }
        }
        public ObservableCollection<OrderStatus> _ProgressModelSLMonth;
        public ObservableCollection<OrderStatus> ProgressModelSLMonth
        {
            get { return _ProgressModelSLMonth; }
            set
            {
                SetProperty(ref _ProgressModelSLMonth, value, nameof(ProgressModelSLMonth));
            }
        }
        public ObservableCollection<OrderStatus> _DataProduct;
        public ObservableCollection<OrderStatus> DataProduct
        {
            get { return _DataProduct; }
            set
            {
                SetProperty(ref _DataProduct, value, nameof(DataProduct));
            }
        }
        public ObservableCollection<OrderStatus> _DataProductMonth;
        public ObservableCollection<OrderStatus> DataProductMonth
        {
            get { return _DataProductMonth; }
            set
            {
                SetProperty(ref _DataProductMonth, value, nameof(DataProductMonth));
            }
        }
        public ObservableCollection<OrderStatus> _DataProductYear;
        public ObservableCollection<OrderStatus> DataProductYear
        {
            get { return _DataProductYear; }
            set
            {
                SetProperty(ref _DataProductYear, value, nameof(DataProductYear));
            }
        }
        public static ObservableCollection<OrderStatus> _ProgressShiftTime;
        public ObservableCollection<OrderStatus> ProgressShiftTime
        {
            get { return _ProgressShiftTime; }
            set
            {
                SetProperty(ref _ProgressShiftTime, value, nameof(ProgressShiftTime));
            }
        }
        public static ObservableCollection<OrderStatus> _ProgressShiftTotalSL;
        public ObservableCollection<OrderStatus> ProgressShiftTotalSL
        {
            get { return _ProgressShiftTotalSL; }
            set
            {
                SetProperty(ref _ProgressShiftTotalSL, value, nameof(ProgressShiftTotalSL));
            }
        }
        public ObservableCollection<OrderStatus> _ProgressOrderModel;
        public ObservableCollection<OrderStatus> ProgressOrderModel
        {
            get { return _ProgressOrderModel; }
            set
            {
                SetProperty(ref _ProgressOrderModel, value, nameof(ProgressOrderModel));
            }
        }


        public ObservableCollection<OrderStatus> _ProgressShiftModel;
        public ObservableCollection<OrderStatus> ProgressShiftModel
        {
            get { return _ProgressShiftModel; }
            set
            {
                SetProperty(ref _ProgressShiftModel, value, nameof(ProgressShiftModel));
            }
        }
        public static ObservableCollection<OrderStatus> _StatictisHourShift;
        public ObservableCollection<OrderStatus> StatictisHourShift
        {
            get { return _StatictisHourShift; }
            set
            {
                SetProperty(ref _StatictisHourShift, value, nameof(StatictisHourShift));
            }
        }
        public static ObservableCollection<OrderStatus> _StatictisHourShift1;
        public ObservableCollection<OrderStatus> StatictisHourShift1
        {
            get { return _StatictisHourShift1; }
            set
            {
                SetProperty(ref _StatictisHourShift1, value, nameof(StatictisHourShift1));
            }
        }
        public ObservableCollection<OrderStatus1> _StatictisHourBasketModel;
        public ObservableCollection<OrderStatus1> StatictisHourBasketModel
        {
            get { return _StatictisHourBasketModel; }
            set
            {
                SetProperty(ref _StatictisHourBasketModel, value, nameof(StatictisHourBasketModel));
            }
        }
        private ObservableCollection<OrderStatus> _StatictisHourDay;

        public ObservableCollection<OrderStatus> StatictisHourDay
        {
            get => _StatictisHourDay;
            set
            {
                SetProperty(ref _StatictisHourDay, value, nameof(StatictisHourDay));

            }
        }
        private ObservableCollection<OrderStatus> _StatictisHourBasket;

        public ObservableCollection<OrderStatus> StatictisHourBasket
        {
            get => _StatictisHourBasket;
            set
            {
                SetProperty(ref _StatictisHourBasket, value, nameof(StatictisHourBasket));

            }
        }
        public static ObservableCollection<OrderStatus> _ProgressShif1;

        public ObservableCollection<OrderStatus> ProgressShif1
        {
            get => _ProgressShif1;
            set
            {
                SetProperty(ref _ProgressShif1, value, nameof(ProgressShif1));

            }
        }
        public static ObservableCollection<OrderStatus> _ProgressShift2;

        public ObservableCollection<OrderStatus> ProgressShift2
        {
            get => _ProgressShift2;
            set
            {
                SetProperty(ref _ProgressShift2, value, nameof(ProgressShift2));

            }
        }
        public static ObservableCollection<OrderStatus> _ProgressShift3;

        public ObservableCollection<OrderStatus> ProgressShift3
        {
            get => _ProgressShift3;
            set
            {
                SetProperty(ref _ProgressShift3, value, nameof(ProgressShift3));

            }
        }
        public static ObservableCollection<OrderStatus> _ProgressShift4;

        public ObservableCollection<OrderStatus> ProgressShift4
        {
            get => _ProgressShift4;
            set
            {
                SetProperty(ref _ProgressShift4, value, nameof(ProgressShift4));

            }
        }
        public static ObservableCollection<OrderStatus> _ProgressShift5;

        public ObservableCollection<OrderStatus> ProgressShift5
        {
            get => _ProgressShift5;
            set
            {
                SetProperty(ref _ProgressShift5, value, nameof(ProgressShift5));

            }
        }
        private ObservableCollection<TableHoya1> _TableHoya1;

        public ObservableCollection<TableHoya1> TableHoya1
        {
            get => _TableHoya1;
            set
            {
                SetProperty(ref _TableHoya1, value, nameof(TableHoya1));

            }
        }
        private ObservableCollection<OrderStatus> _ProgressBasket;

        public ObservableCollection<OrderStatus> ProgressBasket
        {
            get => _ProgressBasket;
            set
            {
                SetProperty(ref _ProgressBasket, value, nameof(ProgressBasket));

            }
        }
        private ObservableCollection<OrderStatus> _ProgressBasket1;

        public ObservableCollection<OrderStatus> ProgressBasket1
        {
            get => _ProgressBasket1;
            set
            {
                SetProperty(ref _ProgressBasket1, value, nameof(ProgressBasket1));

            }
        }
        private ObservableCollection<OrderStatus> _ProgressModel;

        public ObservableCollection<OrderStatus> ProgressModel
        {
            get => _ProgressModel;
            set
            {
                SetProperty(ref _ProgressModel, value, nameof(ProgressModel));

            }
        }
        private ObservableCollection<OrderStatus> _StatictisModel;

        public ObservableCollection<OrderStatus> StatictisModel
        {
            get => _StatictisModel;
            set
            {
                SetProperty(ref _StatictisModel, value, nameof(StatictisModel));

            }
        }
        public ObservableCollection<string> _ListBasket;
        public ObservableCollection<string> ListBasket
        {
            get { return _ListBasket; }
            set { SetProperty(ref _ListBasket, value, nameof(ListBasket)); }
        }
        private ObservableCollection<OrderStatus> _ProgressModelSL;

        public ObservableCollection<OrderStatus> ProgressModelSL
        {
            get => _ProgressModelSL;
            set
            {
                SetProperty(ref _ProgressModelSL, value, nameof(ProgressModelSL));

            }
        }

        private ObservableCollection<OrderStatus> _ProgressSLShift;

        public ObservableCollection<OrderStatus> ProgressSLShift
        {
            get => _ProgressSLShift;
            set
            {
                SetProperty(ref _ProgressSLShift, value, nameof(ProgressSLShift));

            }
        }
        private ObservableCollection<OrderStatus> _ProgressModel1Shift;

        public ObservableCollection<OrderStatus> ProgressModel1Shift
        {
            get => _ProgressModel1Shift;
            set
            {
                SetProperty(ref _ProgressModel1Shift, value, nameof(ProgressModel1Shift));

            }
        }
        private ObservableCollection<OrderStatus> _ProgressModel2Shift;
        public ObservableCollection<OrderStatus> ProgressModel2Shift
        {
            get => _ProgressModel2Shift;
            set
            {
                SetProperty(ref _ProgressModel2Shift, value, nameof(ProgressModel2Shift));

            }
        }

        private ObservableCollection<OrderStatus> _YesterdayStatictisHourShift1;
        public ObservableCollection<OrderStatus> YesterdayStatictisHourShift1
        {
            get => _YesterdayStatictisHourShift1;
            set
            {
                SetProperty(ref _YesterdayStatictisHourShift1, value, nameof(YesterdayStatictisHourShift1));

            }
        }
        private ObservableCollection<OrderStatus> _ProgressModel3Shift;
        public ObservableCollection<OrderStatus> ProgressModel3Shift
        {
            get => _ProgressModel3Shift;
            set
            {
                SetProperty(ref _ProgressModel3Shift, value, nameof(ProgressModel3Shift));

            }
        }
        private ObservableCollection<OrderStatus> _ProgressModel4Shift;
        public ObservableCollection<OrderStatus> ProgressModel4Shift
        {
            get => _ProgressModel4Shift;
            set
            {
                SetProperty(ref _ProgressModel4Shift, value, nameof(ProgressModel4Shift));

            }
        }
        private ObservableCollection<OrderStatus> _ProgressBasketShift;

        public ObservableCollection<OrderStatus> ProgressBasketShift
        {
            get => _ProgressBasketShift;
            set
            {
                SetProperty(ref _ProgressBasketShift, value, nameof(ProgressBasketShift));

            }
        }


        private ObservableCollection<Classlist1> _list1;

        public ObservableCollection<Classlist1> list1
        {
            get => _list1;
            set
            {
                SetProperty(ref _list1, value, nameof(list1));

            }
        }
        public static ObservableCollection<classlistshift> _listShift;

        public ObservableCollection<classlistshift> listShift
        {
            get => _listShift;
            set
            {
                SetProperty(ref _listShift, value, nameof(listShift));

            }
        }

        private ObservableCollection<DataSeries> _serieshour;
        public ObservableCollection<DataSeries> SeriesHours
        {
            get => _serieshour;
            set
            {
                SetProperty(ref _serieshour, value, nameof(SeriesHours));
            }
        }
        private ObservableCollection<DataSeries> _seriesyear;
        public ObservableCollection<DataSeries> Seriesyear
        {
            get => _seriesyear;
            set
            {
                SetProperty(ref _seriesyear, value, nameof(Seriesyear));
            }
        }
        private ObservableCollection<DataSeries> _serieshourbasket;
        public ObservableCollection<DataSeries> SeriesHoursBasket
        {
            get => _serieshourbasket;
            set
            {
                SetProperty(ref _serieshourbasket, value, nameof(SeriesHoursBasket));
            }
        }

        DateTime _labelDatetime;
        public DateTime LabelDatetime
        {
            get => _labelDatetime;
            set => SetProperty(ref _labelDatetime, value, nameof(LabelDatetime));
        }

        MySQLDaTaHoya Sqlexcute = new MySQLDaTaHoya();

        public TableHoya1 clasTablehoya1;
        private readonly string[] ArgumentModel = new string[4] { "Model1", "Model2", "Model3", "Model4" };
        private int[] Model = new int[4];
        private readonly int[] ModelBasket = new int[4];
        private readonly int[] SLModel = new int[4];
        private readonly string[] Argumenthourday = new string[] { "00:00AM", "01:00AM", "02:00AM", "03:00 AM", "04:00 AM", "05:00 AM", "06:00 AM", "07:00 AM", "08:00 AM", "09:00 AM", "10:00 AM", "11:00 AM", "12:00 AM", "13:00 AM", "14:00 AM", "15:00 AM", "16:00 AM", "17:00 AM", "18:00 AM", "19:00 AM", "20:00 AM", "21:00 AM", "22:00 AM", "23:00 AM" };

        private int[] Valuehourday = new int[24];
        private int[] valuedaymonth;

        private TimeSpan[] Arhourday;

        public int _SLBasket;
        public int SLBasket
        {
            get => _SLBasket;
            set { SetProperty(ref _SLBasket, value, nameof(SLBasket)); }
        }
        public int _SLBasketXx;
        public int SLBasketXx
        {
            get => _SLBasketXx;
            set { SetProperty(ref _SLBasketXx, value, nameof(SLBasketXx)); }
        }
        public int _IndexShit;
        public int IndexShift
        {
            get => _IndexShit;
            set => SetProperty(ref _IndexShit, value, nameof(IndexShift));
        }
        public int _QtyModel4;
        public int QtyModel4
        {
            get => _QtyModel4;
            set { SetProperty(ref _QtyModel4, value, nameof(QtyModel4)); }
        }
        public int _QtyModel3;
        public int QtyModel3
        {
            get => _QtyModel3;
            set { SetProperty(ref _QtyModel3, value, nameof(QtyModel3)); }
        }
        public int _QtyModel2;
        public int QtyModel2
        {
            get => _QtyModel2;
            set { SetProperty(ref _QtyModel2, value, nameof(QtyModel2)); }
        }
        public int _QtyModel1;
        public int QtyModel1
        {
            get => _QtyModel1;
            set { SetProperty(ref _QtyModel1, value, nameof(QtyModel1)); }
        }
        public int _QuantityShiftToday;
        public int QuantityShiftToday
        {
            get => _QuantityShiftToday;
            set { SetProperty(ref _QuantityShiftToday, value, nameof(QuantityShiftToday)); }
        }
        public int _QuantityShiftYesterday;
        public int QuantityShiftYesterday
        {
            get => _QuantityShiftYesterday;
            set { SetProperty(ref _QuantityShiftYesterday, value, nameof(QuantityShiftYesterday)); }
        }
        public int _BasketShiftToday;
        public int BasketShiftToday
        {
            get => _BasketShiftToday;
            set { SetProperty(ref _BasketShiftToday, value, nameof(BasketShiftToday)); }
        }
        public int _BasketShiftYesterday;
        public int BasketShiftYesterday
        {
            get => _BasketShiftYesterday;
            set { SetProperty(ref _BasketShiftYesterday, value, nameof(BasketShiftYesterday)); }
        }

        public int _QtyThismonth;
        public int QtyThismonth
        {
            get => _QtyThismonth;
            set { SetProperty(ref _QtyThismonth, value, nameof(QtyThismonth)); }
        }
        public int _sltoday;
        public int sltoday
        {
            get => _sltoday;
            set { SetProperty(ref _sltoday, value, nameof(sltoday)); }
        }
        public int _slthismonth;
        public int slthismonth
        {
            get => _slthismonth;
            set { SetProperty(ref _slthismonth, value, nameof(slthismonth)); }
        }
        public int _slyesterday;
        public int slyesterday
        {
            get => _slyesterday;
            set { SetProperty(ref _slyesterday, value, nameof(slyesterday)); }
        }

        public int _sllastmonth;
        public int sllastmonth
        {
            get => _sllastmonth;
            set { SetProperty(ref _sllastmonth, value, nameof(sllastmonth)); }
        }
        public int _slthisyear;
        public int slthisyear
        {
            get => _slthisyear;
            set { SetProperty(ref _slthisyear, value, nameof(slthisyear)); }
        }
        public int _sllastyear;
        public int sllastyear
        {
            get => _sllastyear;
            set { SetProperty(ref _sllastyear, value, nameof(sllastyear)); }
        }
        public int _slday;
        public int slday
        {
            get => _slday;
            set { SetProperty(ref _slday, value, nameof(slday)); }
        }
        public int _slmonth;
        public int slmonth
        {
            get => _slmonth;
            set { SetProperty(ref _slmonth, value, nameof(slmonth)); }
        }
        public int _slyear;
        public int slyear
        {
            get => _slyear;
            set { SetProperty(ref _slyear, value, nameof(slyear)); }
        }
        string _ImgTang;
        public string ImgTang
        {
            get { return _ImgTang; }
            set
            {
                SetProperty(ref _ImgTang, value, nameof(ImgTang));
            }
        }
        string _ImgTangday;
        public string ImgTangday
        {
            get { return _ImgTangday; }
            set
            {
                SetProperty(ref _ImgTangday, value, nameof(ImgTangday));
            }
        }
        string _ImgTangmonth;
        public string ImgTangmonth
        {
            get { return _ImgTangmonth; }
            set
            {
                SetProperty(ref _ImgTangmonth, value, nameof(ImgTangmonth));
            }
        }
        string _ImgTangyear;
        public string ImgTangyear
        {
            get { return _ImgTangyear; }
            set
            {
                SetProperty(ref _ImgTangyear, value, nameof(ImgTangyear));
            }
        }
        string _ImgTang1;
        public string ImgTang1
        {
            get { return _ImgTang1; }
            set
            {
                SetProperty(ref _ImgTang1, value, nameof(ImgTang1));
            }
        }
        public double _valueCPU;
        public double valueCPU
        {
            get => _valueCPU;
            set { SetProperty(ref _valueCPU, value, nameof(valueCPU)); }
        }
        public double _valueRam;
        public double valueRam
        {
            get => _valueRam;
            set { SetProperty(ref _valueRam, value, nameof(valueRam)); }
        }
        #region abcdefik
        public static int _a;
        public int a
        {
            get => _a;
            set => SetProperty(ref _a, value, nameof(a));
        }
        public static int _b;
        public int b
        {
            get => _b;
            set => SetProperty(ref _b, value, nameof(b));
        }
        public static int _c;
        public int c
        {
            get => _c;
            set => SetProperty(ref _c, value, nameof(c));
        }
        public static int _d;
        public int d
        {
            get => _d;
            set => SetProperty(ref _d, value, nameof(d));
        }
        public static int _e;
        public int e
        {
            get => _e;
            set => SetProperty(ref _e, value, nameof(e));
        }
        public static int _f;
        public int f
        {
            get => _f;
            set => SetProperty(ref _f, value, nameof(f));
        }
        public static int _g;
        public int g
        {
            get => _g;
            set => SetProperty(ref _g, value, nameof(g));
        }
        public static int _h;
        public int h
        {
            get => _h;
            set => SetProperty(ref _h, value, nameof(h));
        }
        public static int _i;
        public int i
        {
            get => _i;
            set => SetProperty(ref _i, value, nameof(i));
        }
        public static int _k;
        public int k
        {
            get => _k;
            set => SetProperty(ref _k, value, nameof(k));
        }
        public static int _l;
        public int l
        {
            get => _l;
            set => SetProperty(ref _l, value, nameof(l));
        }
        public static int _m;
        public int m
        {
            get => _m;
            set => SetProperty(ref _m, value, nameof(m));
        }
        #endregion

        #region isenabled
        bool _CheckOnline;
        public bool CheckOnline
        {
            get { return _CheckOnline; }
            set
            {
                SetProperty(ref _CheckOnline, value, nameof(CheckOnline));
            }
        }
        bool _CheckOffline;
        public bool CheckOffline
        {
            get { return _CheckOffline; }
            set
            {
                SetProperty(ref _CheckOffline, value, nameof(CheckOffline));
            }
        }
        bool _IsenabledDate;
        public bool IsenabledDate
        {
            get { return _IsenabledDate; }
            set
            {
                SetProperty(ref _IsenabledDate, value, nameof(IsenabledDate));
            }
        }

        bool _IsenabledShift;
        public bool IsenabledShift
        {
            get { return _IsenabledShift; }
            set
            {
                SetProperty(ref _IsenabledShift, value, nameof(IsenabledShift));
            }
        }
        bool _IsenabledProduct;
        public bool IsenabledProduct
        {
            get { return _IsenabledProduct; }
            set
            {
                SetProperty(ref _IsenabledProduct, value, nameof(IsenabledProduct));
            }
        }
        bool _IsenabledCompare;
        public bool IsenabledCompare
        {
            get { return _IsenabledCompare; }
            set
            {
                SetProperty(ref _IsenabledCompare, value, nameof(IsenabledCompare));
            }
        }

        #endregion

        public string _Shift;
        public string Shift
        {
            get => _Shift;
            set => SetProperty(ref _Shift, value, nameof(Shift));
        }
        public string _gif;
        public string gif
        {
            get => _gif;
            set => SetProperty(ref _gif, value, nameof(gif));
        }
        public string _imageadmin;
        public string imageadmin
        {
            get => _imageadmin;
            set => SetProperty(ref _imageadmin, value, nameof(imageadmin));
        }
        #endregion
        #region ICommand
        public ICommand Applycommand { get; set; }
        public ICommand Loaded { get; set; }
        public ICommand AddBasket { get; set; }
        public ICommand Product { get; set; }
        public ICommand Click { get; set; }
        public ICommand ApplyShiftcommand { get; set; }
        public ICommand Today { get; set; }
        public ICommand Yestoday { get; set; }
        public ICommand ApplyProduct { get; set; }
        public ICommand ThisMonth { get; set; }
        public ICommand LastMonth { get; set; }
        public ICommand CompareCommand { get; set; }
        public ICommand Detail { get; set; }
        public ICommand ClickSS { get; set; }
        public ICommand ThisYear { get; set; }
        public ICommand LastYear { get; set; }
        public ICommand Back { get; set; }
        public ICommand ONLINE { get; set; }
        public ICommand OFFLINE { get; set; }
        #endregion

        DispatcherTimer timerLoad = new DispatcherTimer();
        DispatcherTimer DongHO = new DispatcherTimer();
        DispatcherTimer timeWrite = new DispatcherTimer();
       
        public DBHOYAViewModel()
        {
            StatictisHourShift = new ObservableCollection<OrderStatus>();
            listShift = new ObservableCollection<classlistshift>();
            ProgressShif1 = new ObservableCollection<OrderStatus>();
            ProgressShift2 = new ObservableCollection<OrderStatus>();
            ProgressShift3 = new ObservableCollection<OrderStatus>();
            ProgressShift4 = new ObservableCollection<OrderStatus>();
            ProgressShift5 = new ObservableCollection<OrderStatus>();
            StatictisHourShift1 = new ObservableCollection<OrderStatus>();
            ProgressShiftTime = new ObservableCollection<OrderStatus>();
            ProgressShiftTotalSL = new ObservableCollection<OrderStatus>();
           
            Loaded = new RelayCommand<object>((p) => { return true; }, (p) =>
            {
                try
                {
                    List<string> Sever = new List<string>();
                    string Systemconfig = System.IO.Directory.GetCurrentDirectory() + @"\" + "A(Sever-Pasword).txt";
                    string Systemconfigmagegift = System.IO.Directory.GetCurrentDirectory() + @"\" + @"image\Online.gif";
                    gif = Systemconfigmagegift;
                    string Systemconfigmageadmin = System.IO.Directory.GetCurrentDirectory() + @"\" + @"image\Hacker.png";
                    imageadmin = Systemconfigmageadmin;
                    using (System.IO.StreamReader sr = new System.IO.StreamReader(Systemconfig))
                    {
                        for (int i = 0; i < 2; i++)
                        {
                            Sever.Add(sr.ReadLine());
                        }

                    }
                    MySQLDaTaHoya.Server = Sever[0];
                    MySQLDaTaHoya.pwd = Sever[1];
                    SelectDatetimes = DateTime.Today;
                    timetoday = DateTime.Now;

                    timelasttoday = new DateTime(timetoday.Year - 1, timetoday.Month - 1, timetoday.Day - 1);
                    IsenabledDate = true;
                    CheckOffline = false;
                    CheckOnline = true;
                    IsenabledCompare = IsenabledDate = IsenabledProduct = IsenabledShift = false;
                    timerLoad.Tick += TimerLoad_Tick;
                    timerLoad.Interval = TimeSpan.FromSeconds(6);

                    timeWrite.Tick += TimeWrite_Tick;
                    timeWrite.Interval = TimeSpan.FromSeconds(5);
                    timeWrite.IsEnabled = true;

                    DongHO.Tick += DongHO_Tick;
                    DongHO.Interval = TimeSpan.FromSeconds(1);
                    DongHO.IsEnabled = false;
                    Loading_Indicator.Finished();
                }
                catch (Exception ex)
                {
                    Loading_Indicator.Finished();
                    MessageBox.Show(ex.Message);
                }



            });
            Back = new RelayCommand<Window>((p) => { return true; }, (p) =>
            {
                try
                {
                    timerLoad.IsEnabled = false;
                    p.Close();
                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message);
                }

            });
            #region comment
            //AddBasket = new RelayCommand<object>((p) => { return true; }, (p) =>
            //{
            //    try
            //    {

            //        string cmd = string.Empty;
            //        string date = SelectDatetimes.ToString("yyyy-MM-dd");
            //        cmd = "SELECT * FROM Hoya1 where Date = '" + date + "' ";
            //        DataTable TableHoya1 = new DataTable();
            //        TableHoya1 = Sqlexcute.Read_Table_Group(cmd);
            //        if (TableHoya1.Rows.Count > 0)
            //        {
            //            ListBasket = new ObservableCollection<string>();
            //            foreach (DataRow item in TableHoya1.Rows)
            //            {
            //                if (!ListBasket.Contains((string)item[2]))
            //                {
            //                    ListBasket.Add((string)item[2]);
            //                }
            //            }
            //            SLBasket = TableHoya1.Rows.Count;
            //        }

            //    }
            //    catch (Exception)
            //    {


            //    }


            //});
            #endregion
            #region Hide
            //Applycommand = new RelayCommand<object>((p) => { return true; }, (p) =>
            //{

            //    try
            //    {
            //        Loading_Indicator.BeingBusy();
            //        string cmd = string.Empty;
            //        string date = SelectDatetimes.ToString("yyyy-MM-dd");
            //        cmd = "SELECT * FROM Hoya1 where Date = '" + date + "' ";
            //        DataTable Tablehoya1 = new DataTable();
            //        Tablehoya1 = Sqlexcute.Read_Table_Group(cmd);
            //        if (Tablehoya1.Rows.Count > 0)
            //        {
            //            Model[0] = Model[1] = Model[2] = Model[3] = 0;
            //            SLModel[0] = SLModel[1] = SLModel[2] = SLModel[3] = 0;
            //            for (int i = 0; i < 24; i++)
            //            {
            //                Valuehourday[i] = 0;
            //            }

            //            foreach (DataRow item in Tablehoya1.Rows)
            //            {
            //                switch ((int)item[3])
            //                {
            //                    case 1:
            //                        Model[0]++;
            //                        for (int i = 0; i < 24; i++)
            //                        {
            //                            SLModel[0] += (int)item[i + 4];
            //                        }
            //                        break;
            //                    case 2:
            //                        Model[1]++;
            //                        for (int i = 0; i < 24; i++)
            //                        {
            //                            SLModel[1] += (int)item[i + 4];
            //                        }
            //                        break;
            //                    case 3:
            //                        Model[2]++;
            //                        for (int i = 0; i < 24; i++)
            //                        {
            //                            SLModel[2] += (int)item[i + 4];
            //                        }
            //                        break;
            //                    case 4:
            //                        Model[3]++;
            //                        for (int i = 0; i < 24; i++)
            //                        {
            //                            SLModel[3] += (int)item[i + 4];
            //                        }
            //                        break;
            //                }
            //                for (int i = 0; i < 24; i++)
            //                {
            //                    Valuehourday[i] += (int)item[i + 4];
            //                }

            //            }
            //            SLBasket = Tablehoya1.Rows.Count;
            //            Qtytoday = SLModel[0] + SLModel[1] + SLModel[2] + SLModel[3];
            //        }
            //        ProgressModelSL = new ObservableCollection<OrderStatus>();
            //        for (int i = 0; i < 4; i++)
            //        {
            //            ProgressModelSL.Add(new OrderStatus() { Argument = ArgumentModel[i], Value = SLModel[i] });
            //        }
            //        ProgressModel = new ObservableCollection<OrderStatus>();
            //        for (int i = 0; i < 4; i++)
            //        {
            //            ProgressModel.Add(new OrderStatus() { Argument = ArgumentModel[i], Value = Model[i] });
            //        }
            //        StatictisHourDay = new ObservableCollection<OrderStatus>();
            //        for (int i = 0; i < 24; i++)
            //        {
            //            StatictisHourDay.Add(new OrderStatus() { Argument = Argumenthourday[i], Value = Valuehourday[i] });
            //        }

            //        StatictisModel = new ObservableCollection<OrderStatus>();
            //        for (int i = 0; i < 4; i++)
            //        {
            //            StatictisModel.Add(new OrderStatus() { Argument = ArgumentModel[i], Value = SLModel[i] });
            //        }

            //        TableHoya1 = new ObservableCollection<TableHoya1>();
            //        foreach (DataRow item in Tablehoya1.Rows)
            //        {
            //            int TempSL = 0;
            //            for (int i = 0; i < 24; i++)
            //            {
            //                TempSL += (int)item[i + 4];
            //            }
            //            TableHoya1.Add(new Class.TableHoya1() { date = SelectDatetimes, Basket = (string)item[2], Model = (int)item[3], SoLuong = TempSL });
            //        }


            //        Loading_Indicator.Finished();
            //    }
            //    catch (Exception)
            //    {
            //        Loading_Indicator.Finished();

            //    }

            //});
            #endregion

            Applycommand = new RelayCommand<object>((p) => { return true; }, (p) =>
            {

                try
                {
                    
                    Loading_Indicator.BeingBusy();
                    Qtytoday = 0;
                    SLBasket = 0;
                    TableHoya1 = new ObservableCollection<TableHoya1>();
                    string cmd = string.Empty;
                    string date = SelectDatetimes.ToString("yyyy-MM-dd");
                    cmd = "SELECT * FROM DateShift1 where Ngay = '" + date + "' ";
                    DataTable Tablehoya1 = new DataTable();
                    Tablehoya1 = Sqlexcute.Read_Table_Group(cmd);
                    Model[0] = Model[1] = Model[2] = Model[3] = 0;
                    SLModel[0] = SLModel[1] = SLModel[2] = SLModel[3] = 0;
                    Valuehourday = new int[24];
                    if (Tablehoya1.Rows.Count > 0)
                    {
                        foreach (DataRow item in Tablehoya1.Rows)
                        {
                            switch ((int)item[5])
                            {
                                case 1:
                                    Model[0]++;
                                    SLModel[0] += (int)item[4];
                                    break;
                                case 2:
                                    Model[1]++;
                                    SLModel[1] += (int)item[4];
                                    break;
                                case 3:
                                    Model[2]++;
                                    SLModel[2] += (int)item[4];
                                    break;
                                case 4:
                                    Model[3]++;
                                    SLModel[3] += (int)item[4];
                                    break;
                            }
                            TimeSpan temhour = (TimeSpan)item[2];

                            switch (temhour.Hours)
                            {
                                case 8:
                                    Valuehourday[8] += (int)item[4];
                                    break;
                                case 9:
                                    Valuehourday[9] += (int)item[4];
                                    break;
                                case 10:
                                    Valuehourday[10] += (int)item[4];
                                    break;
                                case 11:
                                    Valuehourday[11] += (int)item[4];
                                    break;
                                case 12:
                                    Valuehourday[12] += (int)item[4];
                                    break;
                                case 13:
                                    Valuehourday[13] += (int)item[4];
                                    break;
                                case 14:
                                    Valuehourday[14] += (int)item[4];
                                    break;
                                case 15:
                                    Valuehourday[15] += (int)item[4];
                                    break;
                            }
                            TableHoya1.Add(new TableHoya1() { date = SelectDatetimes, Basket = (string)item[3], Model = (int)item[5], Time = (TimeSpan)item[2] });

                        }
                        SLBasket = Model[0] + Model[1] + Model[2] + Model[3];
                        Qtytoday = SLModel[0] + SLModel[1] + SLModel[2] + SLModel[3];
                    }
                    cmd = "SELECT * FROM DateShift2 where Ngay = '" + date + "' ";
                    Tablehoya1 = Sqlexcute.Read_Table_Group(cmd);
                    if (Tablehoya1.Rows.Count > 0)
                    {
                        foreach (DataRow item in Tablehoya1.Rows)
                        {
                            switch ((int)item[5])
                            {
                                case 1:
                                    Model[0]++;
                                    SLModel[0] += (int)item[4];
                                    break;
                                case 2:
                                    Model[1]++;
                                    SLModel[1] += (int)item[4];
                                    break;
                                case 3:
                                    Model[2]++;
                                    SLModel[2] += (int)item[4];
                                    break;
                                case 4:
                                    Model[3]++;
                                    SLModel[3] += (int)item[4];
                                    break;
                            }
                            TimeSpan temhour = (TimeSpan)item[2];

                            switch (temhour.Hours)
                            {
                                case 16:
                                    Valuehourday[16] += (int)item[4];
                                    break;
                                case 17:
                                    Valuehourday[17] += (int)item[4];
                                    break;
                                case 18:
                                    Valuehourday[18] += (int)item[4];
                                    break;
                                case 19:
                                    Valuehourday[19] += (int)item[4];
                                    break;
                                case 20:
                                    Valuehourday[20] += (int)item[4];
                                    break;
                                case 21:
                                    Valuehourday[21] += (int)item[4];
                                    break;
                                case 22:
                                    Valuehourday[22] += (int)item[4];
                                    break;
                                case 23:
                                    Valuehourday[23] += (int)item[4];
                                    break;
                            }
                            TableHoya1.Add(new TableHoya1() { date = SelectDatetimes, Basket = (string)item[3], Model = (int)item[5], Time = (TimeSpan)item[2] });
                        }
                        SLBasket = Model[0] + Model[1] + Model[2] + Model[3];
                        Qtytoday = SLModel[0] + SLModel[1] + SLModel[2] + SLModel[3];

                    }
                    cmd = "SELECT * FROM DateShift3 where Ngay = '" + date + "' ";
                    Tablehoya1 = Sqlexcute.Read_Table_Group(cmd);
                    if (Tablehoya1.Rows.Count > 0)
                    {
                        foreach (DataRow item in Tablehoya1.Rows)
                        {
                            switch ((int)item[5])
                            {
                                case 1:
                                    Model[0]++;
                                    SLModel[0] += (int)item[4];
                                    break;
                                case 2:
                                    Model[1]++;
                                    SLModel[1] += (int)item[4];
                                    break;
                                case 3:
                                    Model[2]++;
                                    SLModel[2] += (int)item[4];
                                    break;
                                case 4:
                                    Model[3]++;
                                    SLModel[3] += (int)item[4];
                                    break;
                            }
                            TimeSpan temhour = (TimeSpan)item[2];

                            switch (temhour.Hours)
                            {
                                case 0:
                                    Valuehourday[0] += (int)item[4];
                                    break;
                                case 1:
                                    Valuehourday[1] += (int)item[4];
                                    break;
                                case 2:
                                    Valuehourday[2] += (int)item[4];
                                    break;
                                case 3:
                                    Valuehourday[3] += (int)item[4];
                                    break;
                                case 4:
                                    Valuehourday[4] += (int)item[4];
                                    break;
                                case 5:
                                    Valuehourday[5] += (int)item[4];
                                    break;
                                case 6:
                                    Valuehourday[6] += (int)item[4];
                                    break;
                                case 7:
                                    Valuehourday[7] += (int)item[4];
                                    break;
                            }
                            TableHoya1.Add(new TableHoya1() { date = SelectDatetimes, Basket = (string)item[3], Model = (int)item[5], Time = (TimeSpan)item[2] });
                        }
                        SLBasket = Model[0] + Model[1] + Model[2] + Model[3];
                        Qtytoday = SLModel[0] + SLModel[1] + SLModel[2] + SLModel[3];


                    }

                    ProgressModelSL = new ObservableCollection<OrderStatus>();
                    for (int i = 0; i < 4; i++)
                    {
                        ProgressModelSL.Add(new OrderStatus() { Argument = ArgumentModel[i], Value = SLModel[i] });
                    }
                    ProgressModel = new ObservableCollection<OrderStatus>();
                    for (int i = 0; i < 4; i++)
                    {
                        ProgressModel.Add(new OrderStatus() { Argument = ArgumentModel[i], Value = Model[i] });
                    }
                    StatictisModel = new ObservableCollection<OrderStatus>();
                    for (int i = 0; i < 4; i++)
                    {
                        StatictisModel.Add(new OrderStatus() { Argument = ArgumentModel[i], Value = SLModel[i] });
                    }
                    StatictisHourDay = new ObservableCollection<OrderStatus>();
                    for (int i = 0; i < 24; i++)
                    {
                        StatictisHourDay.Add(new OrderStatus() { Argument = Argumenthourday[i], Value = Valuehourday[i] });
                    }
                    Loading_Indicator.Finished();
                }
                catch (Exception ex)
                {
                    Loading_Indicator.Finished();
                    MessageBox.Show(ex.Message);

                }

            });
            Product = new RelayCommand<object>((p) => { return true; }, (p) =>
            {
                try
                {
                    if ((int)p == 0 && CheckOffline)
                    {
                        IsenabledDate = true;
                        IsenabledProduct = false;
                        IsenabledCompare = false;
                        IsenabledShift = false;
                    }
                    else if ((int)p == 1 && CheckOffline)
                    {
                        IsenabledDate = false;
                        IsenabledProduct = true;
                        IsenabledCompare = false;
                        IsenabledShift = false;
                    }
                    else if ((int)p == 2 && CheckOffline)
                    {
                        IsenabledDate = false;
                        IsenabledProduct = false;
                        IsenabledCompare = false;
                        IsenabledShift = true;
                        timerLoad.IsEnabled = false;
                    }

                    else if ((int)p == 3 && CheckOffline)
                    {
                        IsenabledDate = false;
                        IsenabledProduct = false;
                        IsenabledCompare = true;
                        IsenabledShift = false;
                    }
                    else if ((int)p == 4 && CheckOffline)
                    {

                    }
                    if ((int)p == 0)
                    {
                        timerLoad.IsEnabled = false;
                    }
                    else if ((int)p == 1)
                    {
                        timerLoad.IsEnabled = false;
                    }
                    else if ((int)p == 2 && CheckOnline)
                    {
                        timerLoad.IsEnabled = true;
                    }
                    else if ((int)p == 3)
                    {
                        timerLoad.IsEnabled = false;
                    }
                    else if ((int)p == 4)
                    {
                        timerLoad.IsEnabled = false;
                    }
                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message);
                }

            });
            Today = new RelayCommand<object>((p) => { return true; }, (p) =>
            {
                try
                {
                    Loading_Indicator.BeingBusy();
                    string[] ssTY = new string[] { "Yesterday", "Today" };
                    sltoday = slyesterday = 0;
                    DateTime today = DateTime.Today;
                    day = today.ToString("dd/MM/yyyy");
                    string cmd = string.Empty;
                    string date = today.ToString("yyyy-MM-dd");
                    cmd = "SELECT * FROM DateShift1 where Ngay = '" + date + "' ";
                    DataTable TableHoya1 = new DataTable();
                    TableHoya1 = Sqlexcute.Read_Table_Group(cmd);
                    for (int i = 0; i < 24; i++)
                    {
                        Valuehourday[i] = 0;
                    }

                    if (TableHoya1.Rows.Count > 0)
                    {
                        foreach (DataRow item in TableHoya1.Rows)
                        {
                            TimeSpan temhour = (TimeSpan)item[2];

                            switch (temhour.Hours)
                            {
                                case 8:
                                    Valuehourday[8] += (int)item[4];
                                    break;
                                case 9:
                                    Valuehourday[9] += (int)item[4];
                                    break;
                                case 10:
                                    Valuehourday[10] += (int)item[4];
                                    break;
                                case 11:
                                    Valuehourday[11] += (int)item[4];
                                    break;
                                case 12:
                                    Valuehourday[12] += (int)item[4];
                                    break;
                                case 13:
                                    Valuehourday[13] += (int)item[4];
                                    break;
                                case 14:
                                    Valuehourday[14] += (int)item[4];
                                    break;
                                case 15:
                                    Valuehourday[15] += (int)item[4];
                                    break;
                            }

                        }
                    }
                    cmd = "SELECT * FROM DateShift2 where Ngay = '" + date + "' ";
                    TableHoya1 = Sqlexcute.Read_Table_Group(cmd);
                    if (TableHoya1.Rows.Count > 0)
                    {
                        foreach (DataRow item in TableHoya1.Rows)
                        {
                            TimeSpan temhour = (TimeSpan)item[2];

                            switch (temhour.Hours)
                            {
                                case 16:
                                    Valuehourday[16] += (int)item[4];
                                    break;
                                case 17:
                                    Valuehourday[17] += (int)item[4];
                                    break;
                                case 18:
                                    Valuehourday[18] += (int)item[4];
                                    break;
                                case 19:
                                    Valuehourday[19] += (int)item[4];
                                    break;
                                case 20:
                                    Valuehourday[20] += (int)item[4];
                                    break;
                                case 21:
                                    Valuehourday[21] += (int)item[4];
                                    break;
                                case 22:
                                    Valuehourday[22] += (int)item[4];
                                    break;
                                case 23:
                                    Valuehourday[23] += (int)item[4];
                                    break;
                            }

                        }
                    }
                    cmd = "SELECT * FROM DateShift3 where Ngay = '" + date + "' ";
                    TableHoya1 = Sqlexcute.Read_Table_Group(cmd);
                    if (TableHoya1.Rows.Count > 0)
                    {
                        foreach (DataRow item in TableHoya1.Rows)
                        {
                            TimeSpan temhour = (TimeSpan)item[2];

                            switch (temhour.Hours)
                            {
                                case 0:
                                    Valuehourday[0] += (int)item[4];
                                    break;
                                case 1:
                                    Valuehourday[1] += (int)item[4];
                                    break;
                                case 2:
                                    Valuehourday[2] += (int)item[4];
                                    break;
                                case 3:
                                    Valuehourday[3] += (int)item[4];
                                    break;
                                case 4:
                                    Valuehourday[4] += (int)item[4];
                                    break;
                                case 5:
                                    Valuehourday[5] += (int)item[4];
                                    break;
                                case 6:
                                    Valuehourday[6] += (int)item[4];
                                    break;
                                case 7:
                                    Valuehourday[7] += (int)item[4];
                                    break;
                            }
                        }
                    }
                    DataProduct = new ObservableCollection<OrderStatus>();
                    for (int i = 0; i < 24; i++)
                    {
                        DataProduct.Add(new OrderStatus() { Argument = Argumenthourday[i], Value = Valuehourday[i] });
                        sltoday += Valuehourday[i];
                        slday = sltoday;
                    }
                    ///////////slyessyterday

                    date = today.AddDays(-1).ToString("yyyy-MM-dd");
                    cmd = "SELECT * FROM DateShift1 where Ngay = '" + date + "' ";
                    TableHoya1 = Sqlexcute.Read_Table_Group(cmd);
                    if (TableHoya1.Rows.Count > 0)
                    {
                        foreach (DataRow item in TableHoya1.Rows)
                        {
                            slyesterday += (int)item[4];
                        }
                    }
                    cmd = "SELECT * FROM DateShift2 where Ngay = '" + date + "' ";
                    TableHoya1 = Sqlexcute.Read_Table_Group(cmd);
                    if (TableHoya1.Rows.Count > 0)
                    {
                        foreach (DataRow item in TableHoya1.Rows)
                        {
                            slyesterday += (int)item[4];

                        }
                    }
                    cmd = "SELECT * FROM DateShift3 where Ngay = '" + date + "' ";
                    TableHoya1 = Sqlexcute.Read_Table_Group(cmd);
                    if (TableHoya1.Rows.Count > 0)
                    {
                        foreach (DataRow item in TableHoya1.Rows)
                        {
                            slyesterday += (int)item[4];
                        }
                    }
                    if (sltoday > slyesterday)
                    {
                        string Systemconfigmagetangday = System.IO.Directory.GetCurrentDirectory() + @"\" + @"image\trendUp.png";

                        ImgTangday = Systemconfigmagetangday;
                    }
                    else if (sltoday < slyesterday)
                    {
                        string Systemconfigmagetangday = System.IO.Directory.GetCurrentDirectory() + @"\" + @"image\trenDown.png";
                        ImgTangday = Systemconfigmagetangday;
                    }
                    else
                    {
                        ImgTangday = null;
                    }
                    Loading_Indicator.Finished();
                }
                catch (Exception ex)
                {
                    Loading_Indicator.Finished();
                    MessageBox.Show(ex.Message);
                }

            });
            Yestoday = new RelayCommand<object>((p) => { return true; }, (p) =>
            {
                try
                {
                    Loading_Indicator.BeingBusy();
                    slyesterday = sltoday = 0;
                    DateTime today = DateTime.Today;
                    day = today.AddDays(-1).ToString("dd/MM/yyyy");
                    string cmd = string.Empty;
                    string date = today.AddDays(-1).ToString("yyyy-MM-dd");
                    cmd = "SELECT * FROM DateShift1 where Ngay = '" + date + "' ";
                    DataTable TableHoya1 = new DataTable();
                    TableHoya1 = Sqlexcute.Read_Table_Group(cmd);
                    for (int i = 0; i < 24; i++)
                    {
                        Valuehourday[i] = 0;
                    }
                    if (TableHoya1.Rows.Count > 0)
                    {
                        foreach (DataRow item in TableHoya1.Rows)
                        {
                            TimeSpan temhour = (TimeSpan)item[2];

                            switch (temhour.Hours)
                            {
                                case 8:
                                    Valuehourday[8] += (int)item[4];
                                    break;
                                case 9:
                                    Valuehourday[9] += (int)item[4];
                                    break;
                                case 10:
                                    Valuehourday[10] += (int)item[4];
                                    break;
                                case 11:
                                    Valuehourday[11] += (int)item[4];
                                    break;
                                case 12:
                                    Valuehourday[12] += (int)item[4];
                                    break;
                                case 13:
                                    Valuehourday[13] += (int)item[4];
                                    break;
                                case 14:
                                    Valuehourday[14] += (int)item[4];
                                    break;
                                case 15:
                                    Valuehourday[15] += (int)item[4];
                                    break;
                            }
                        }
                    }
                    cmd = "SELECT * FROM DateShift2 where Ngay = '" + date + "' ";
                    TableHoya1 = Sqlexcute.Read_Table_Group(cmd);
                    if (TableHoya1.Rows.Count > 0)
                    {
                        foreach (DataRow item in TableHoya1.Rows)
                        {
                            TimeSpan temhour = (TimeSpan)item[2];

                            switch (temhour.Hours)
                            {
                                case 16:
                                    Valuehourday[16] += (int)item[4];
                                    break;
                                case 17:
                                    Valuehourday[17] += (int)item[4];
                                    break;
                                case 18:
                                    Valuehourday[18] += (int)item[4];
                                    break;
                                case 19:
                                    Valuehourday[19] += (int)item[4];
                                    break;
                                case 20:
                                    Valuehourday[20] += (int)item[4];
                                    break;
                                case 21:
                                    Valuehourday[21] += (int)item[4];
                                    break;
                                case 22:
                                    Valuehourday[22] += (int)item[4];
                                    break;
                                case 23:
                                    Valuehourday[23] += (int)item[4];
                                    break;
                            }
                        }
                    }
                    cmd = "SELECT * FROM DateShift3 where Ngay = '" + date + "' ";
                    TableHoya1 = Sqlexcute.Read_Table_Group(cmd);
                    if (TableHoya1.Rows.Count > 0)
                    {
                        foreach (DataRow item in TableHoya1.Rows)
                        {
                            TimeSpan temhour = (TimeSpan)item[2];

                            switch (temhour.Hours)
                            {
                                case 0:
                                    Valuehourday[0] += (int)item[4];
                                    break;
                                case 1:
                                    Valuehourday[1] += (int)item[4];
                                    break;
                                case 2:
                                    Valuehourday[2] += (int)item[4];
                                    break;
                                case 3:
                                    Valuehourday[3] += (int)item[4];
                                    break;
                                case 4:
                                    Valuehourday[4] += (int)item[4];
                                    break;
                                case 5:
                                    Valuehourday[5] += (int)item[4];
                                    break;
                                case 6:
                                    Valuehourday[6] += (int)item[4];
                                    break;
                                case 7:
                                    Valuehourday[7] += (int)item[4];
                                    break;
                            }
                        }
                    }
                    DataProduct = new ObservableCollection<OrderStatus>();
                    for (int i = 0; i < 24; i++)
                    {
                        DataProduct.Add(new OrderStatus() { Argument = Argumenthourday[i], Value = Valuehourday[i] });
                        slyesterday += Valuehourday[i];
                        slday = slyesterday;
                    }
                    ///////////slyessyterday

                    date = today.ToString("yyyy-MM-dd");
                    cmd = "SELECT * FROM DateShift1 where Ngay = '" + date + "' ";
                    TableHoya1 = Sqlexcute.Read_Table_Group(cmd);
                    if (TableHoya1.Rows.Count > 0)
                    {
                        foreach (DataRow item in TableHoya1.Rows)
                        {
                            sltoday += (int)item[4];
                        }
                    }
                    cmd = "SELECT * FROM DateShift2 where Ngay = '" + date + "' ";
                    TableHoya1 = Sqlexcute.Read_Table_Group(cmd);
                    if (TableHoya1.Rows.Count > 0)
                    {
                        foreach (DataRow item in TableHoya1.Rows)
                        {
                            sltoday += (int)item[4];

                        }
                    }
                    cmd = "SELECT * FROM DateShift3 where Ngay = '" + date + "' ";
                    TableHoya1 = Sqlexcute.Read_Table_Group(cmd);
                    if (TableHoya1.Rows.Count > 0)
                    {
                        foreach (DataRow item in TableHoya1.Rows)
                        {
                            sltoday += (int)item[4];
                        }
                    }
                    if (sltoday > slyesterday)
                    {
                        ImgTangday = @"F:\Cong_Viec\IOT\IotFactory\IotFactory\SourcesImage\Image\trendUp.png";
                    }
                    else if (sltoday < slyesterday)
                    {
                        ImgTangday = @"F:\Cong_Viec\IOT\IotFactory\IotFactory\SourcesImage\Image\trenDown.png";
                    }
                    else
                    {
                        ImgTangday = null;
                    }
                    Loading_Indicator.Finished();
                }
                catch (Exception ex)
                {

                    Loading_Indicator.Finished();
                    MessageBox.Show(ex.Message);
                }

            });
            ApplyProduct = new RelayCommand<object>((p) => { return true; }, (p) =>
            {
                try
                {
                    Loading_Indicator.BeingBusy();
                    int[] ModelMonth = new int[4];
                    int[] Thisyear = new int[4];
                    int[] Lastyear = new int[4];
                    /////gio theo ngay
                    day = SelectDatetimes.ToString("dd/MM/yyyy");
                    string cmd = string.Empty;
                    string date = SelectDatetimes.ToString("yyyy-MM-dd");
                    cmd = "SELECT * FROM DateShift1 where Ngay = '" + date + "' ";
                    DataTable TableHoya1 = new DataTable();
                    TableHoya1 = Sqlexcute.Read_Table_Group(cmd);
                    for (int i = 0; i < 24; i++)
                    {
                        Valuehourday[i] = 0;
                    }
                    QtyThismonth = slyear = slday = slmonth = 0;

                    if (TableHoya1.Rows.Count > 0)
                    {
                        foreach (DataRow item in TableHoya1.Rows)
                        {
                            TimeSpan temhour = (TimeSpan)item[2];

                            switch (temhour.Hours)
                            {
                                case 8:
                                    Valuehourday[8] += (int)item[4];
                                    break;
                                case 9:
                                    Valuehourday[9] += (int)item[4];
                                    break;
                                case 10:
                                    Valuehourday[10] += (int)item[4];
                                    break;
                                case 11:
                                    Valuehourday[11] += (int)item[4];
                                    break;
                                case 12:
                                    Valuehourday[12] += (int)item[4];
                                    break;
                                case 13:
                                    Valuehourday[13] += (int)item[4];
                                    break;
                                case 14:
                                    Valuehourday[14] += (int)item[4];
                                    break;
                                case 15:
                                    Valuehourday[15] += (int)item[4];
                                    break;
                            }
                        }
                    }
                    cmd = "SELECT * FROM DateShift2 where Ngay = '" + date + "' ";
                    TableHoya1 = Sqlexcute.Read_Table_Group(cmd);
                    if (TableHoya1.Rows.Count > 0)
                    {
                        foreach (DataRow item in TableHoya1.Rows)
                        {
                            TimeSpan temhour = (TimeSpan)item[2];

                            switch (temhour.Hours)
                            {
                                case 16:
                                    Valuehourday[16] += (int)item[4];
                                    break;
                                case 17:
                                    Valuehourday[17] += (int)item[4];
                                    break;
                                case 18:
                                    Valuehourday[18] += (int)item[4];
                                    break;
                                case 19:
                                    Valuehourday[19] += (int)item[4];
                                    break;
                                case 20:
                                    Valuehourday[20] += (int)item[4];
                                    break;
                                case 21:
                                    Valuehourday[21] += (int)item[4];
                                    break;
                                case 22:
                                    Valuehourday[22] += (int)item[4];
                                    break;
                                case 23:
                                    Valuehourday[23] += (int)item[4];
                                    break;
                            }
                        }
                    }
                    cmd = "SELECT * FROM DateShift3 where Ngay = '" + date + "' ";
                    TableHoya1 = Sqlexcute.Read_Table_Group(cmd);
                    if (TableHoya1.Rows.Count > 0)
                    {
                        foreach (DataRow item in TableHoya1.Rows)
                        {
                            TimeSpan temhour = (TimeSpan)item[2];

                            switch (temhour.Hours)
                            {
                                case 0:
                                    Valuehourday[0] += (int)item[4];
                                    break;
                                case 1:
                                    Valuehourday[1] += (int)item[4];
                                    break;
                                case 2:
                                    Valuehourday[2] += (int)item[4];
                                    break;
                                case 3:
                                    Valuehourday[3] += (int)item[4];
                                    break;
                                case 4:
                                    Valuehourday[4] += (int)item[4];
                                    break;
                                case 5:
                                    Valuehourday[5] += (int)item[4];
                                    break;
                                case 6:
                                    Valuehourday[6] += (int)item[4];
                                    break;
                                case 7:
                                    Valuehourday[7] += (int)item[4];
                                    break;
                            }
                        }
                    }
                    DataProduct = new ObservableCollection<OrderStatus>();
                    for (int i = 0; i < 24; i++)
                    {
                        DataProduct.Add(new OrderStatus() { Argument = Argumenthourday[i], Value = Valuehourday[i] });
                        slday += Valuehourday[i];
                    }

                    ////// ngay theo thang
                    List<DateTime> listdate = new List<DateTime>();
                    month = SelectDatetimes.ToString("MM/yyyy");
                    cmd = "SELECT * FROM DateShift1 WHERE MONTH(Ngay) = MONTH(" + "\" " + date + "\"" + ") and year(Ngay)=year(" + "\" " + date + "\"" + ")";
                    cmd = cmd.Replace(@"\", "");
                    DataTable TableHoya1thang = new DataTable();
                    TableHoya1thang = Sqlexcute.Read_Table_Group(cmd);
                    cmd = "SELECT * FROM DateShift2 WHERE MONTH(Ngay) = MONTH(" + "\" " + date + "\"" + ") and year(Ngay)=year(" + "\" " + date + "\"" + ")";
                    cmd = cmd.Replace(@"\", "");
                    DataTable TableHoya2 = new DataTable();
                    TableHoya2 = Sqlexcute.Read_Table_Group(cmd);
                    cmd = "SELECT * FROM DateShift3 WHERE MONTH(Ngay) = MONTH(" + "\" " + date + "\"" + ") and year(Ngay)=year(" + "\" " + date + "\"" + ")";
                    cmd = cmd.Replace(@"\", "");
                    DataTable TableHoya3 = new DataTable();
                    TableHoya3 = Sqlexcute.Read_Table_Group(cmd);
                    foreach (DataRow item in TableHoya2.Rows)
                    {
                        TableHoya1thang.Rows.Add(item.ItemArray);
                    }
                    foreach (DataRow item in TableHoya3.Rows)
                    {
                        TableHoya1thang.Rows.Add(item.ItemArray);
                    }

                    foreach (DataRow item in TableHoya1thang.Rows)
                    {
                        DateTime tem = (DateTime)item[1];
                        string tempdate = tem.ToString("yyyy-MM-dd");
                        if (!listdate.Contains(tem))
                        {
                            listdate.Add(tem);
                        }
                        valuedaymonth = new int[listdate.Count];
                    }
                    listdate.Sort();
                    foreach (DataRow item in TableHoya1thang.Rows)
                    {
                        for (int i = 0; i < listdate.Count; i++)
                        {
                            if ((DateTime)item[1] == listdate[i])
                            {
                                valuedaymonth[i] += (int)item[4];
                                switch ((int)item[5])
                                {
                                    case 1:
                                        ModelMonth[0] += (int)item[4];
                                        break;
                                    case 2:
                                        ModelMonth[1] += (int)item[4];
                                        break;
                                    case 3:
                                        ModelMonth[2] += (int)item[4];
                                        break;
                                    case 4:
                                        ModelMonth[3] += (int)item[4];
                                        break;
                                }
                            }
                        }
                    }
                    DataProductMonth = new ObservableCollection<OrderStatus>();
                    for (int i = 0; i < listdate.Count; i++)
                    {
                        DataProductMonth.Add(new OrderStatus() { Argument = listdate[i].ToString("yyyy-MM-dd"), Value = valuedaymonth[i] });
                        QtyThismonth += valuedaymonth[i];
                        slmonth += valuedaymonth[i];

                    }
                    /////processmodelslmonth
                    ProgressModelSLMonth = new ObservableCollection<OrderStatus>();
                    for (int i = 0; i < 4; i++)
                    {
                        ProgressModelSLMonth.Add(new OrderStatus() { Argument = ArgumentModel[i], Value = ModelMonth[i] });

                    }
                    //////////// thang theo nam 
                    year = SelectDatetimes.ToString("yyyy");
                    int[] valueMonth = new int[12];
                    string[] arMonth = new string[12] { "January", "February", "March", "April", "May", "June", "July", "August", "September", "October", "November", "December" };
                    cmd = string.Empty;
                    date = SelectDatetimes.ToString("yyyy-MM-dd");
                    cmd = "SELECT * FROM DateShift1 WHERE year(Ngay) = year(" + "\" " + date + "\"" + ")";
                    cmd = cmd.Replace(@"\", "");
                    DataTable TableHoya1nam = new DataTable();
                    TableHoya1nam = Sqlexcute.Read_Table_Group(cmd);
                    cmd = "SELECT * FROM DateShift2 WHERE year(Ngay) = year(" + "\" " + date + "\"" + ")";
                    cmd = cmd.Replace(@"\", "");
                    DataTable TableHoya2nam = new DataTable();
                    TableHoya2nam = Sqlexcute.Read_Table_Group(cmd);
                    cmd = "SELECT * FROM DateShift3 WHERE year(Ngay) = year(" + "\" " + date + "\"" + ")";
                    cmd = cmd.Replace(@"\", "");
                    DataTable TableHoya3nam = new DataTable();
                    TableHoya3nam = Sqlexcute.Read_Table_Group(cmd);

                    foreach (DataRow item in TableHoya2nam.Rows)
                    {
                        TableHoya1nam.Rows.Add(item.ItemArray);
                    }
                    foreach (DataRow item in TableHoya3nam.Rows)
                    {
                        TableHoya1nam.Rows.Add(item.ItemArray);
                    }

                    foreach (DataRow item in TableHoya1nam.Rows)
                    {
                        DateTime month = (DateTime)item[1];
                        switch (month.Month)
                        {
                            case 1:
                                valueMonth[0] += (int)item[4];
                                break;
                            case 2:
                                valueMonth[1] += (int)item[4];
                                break;
                            case 3:
                                valueMonth[2] += (int)item[4];
                                break;
                            case 4:
                                valueMonth[3] += (int)item[4];
                                break;
                            case 5:
                                valueMonth[4] += (int)item[4];
                                break;
                            case 6:
                                valueMonth[5] += (int)item[4];
                                break;
                            case 7:
                                valueMonth[6] += (int)item[4];
                                break;
                            case 8:
                                valueMonth[7] += (int)item[4];
                                break;
                            case 9:
                                valueMonth[8] += (int)item[4];
                                break;
                            case 10:
                                valueMonth[9] += (int)item[4];
                                break;
                            case 11:
                                valueMonth[10] += (int)item[4];
                                break;
                            case 12:
                                valueMonth[11] += (int)item[4];
                                break;

                        }
                        switch ((int)item[5])
                        {
                            case 1:
                                Thisyear[0] += (int)item[4];
                                break;
                            case 2:
                                Thisyear[1] += (int)item[4];
                                break;
                            case 3:
                                Thisyear[2] += (int)item[4];
                                break;
                            case 4:
                                Thisyear[3] += (int)item[4];
                                break;
                        }
                    }

                    DataProductYear = new ObservableCollection<OrderStatus>();
                    for (int i = 0; i < 12; i++)
                    {
                        DataProductYear.Add(new OrderStatus() { Argument = arMonth[i], Value = valueMonth[i] });
                        slyear += valueMonth[i];

                    }
                    //////////// thang theo nam ngoai
                    year = SelectDatetimes.ToString("yyyy");
                    date = SelectDatetimes.AddYears(-1).ToString("yyyy-MM-dd");
                    cmd = "SELECT * FROM DateShift1 WHERE year(Ngay) = year(" + "\" " + date + "\"" + ")";
                    cmd = cmd.Replace(@"\", "");

                    TableHoya1nam = Sqlexcute.Read_Table_Group(cmd);
                    cmd = "SELECT * FROM DateShift2 WHERE year(Ngay) = year(" + "\" " + date + "\"" + ")";
                    cmd = cmd.Replace(@"\", "");

                    TableHoya2nam = Sqlexcute.Read_Table_Group(cmd);
                    cmd = "SELECT * FROM DateShift3 WHERE year(Ngay) = year(" + "\" " + date + "\"" + ")";
                    cmd = cmd.Replace(@"\", "");

                    TableHoya3nam = Sqlexcute.Read_Table_Group(cmd);

                    foreach (DataRow item in TableHoya2nam.Rows)
                    {
                        TableHoya1nam.Rows.Add(item.ItemArray);
                    }
                    foreach (DataRow item in TableHoya3nam.Rows)
                    {
                        TableHoya1nam.Rows.Add(item.ItemArray);
                    }

                    foreach (DataRow item in TableHoya1nam.Rows)
                    {
                        switch ((int)item[5])
                        {
                            case 1:
                                Lastyear[0] += (int)item[4];
                                break;
                            case 2:
                                Lastyear[1] += (int)item[4];
                                break;
                            case 3:
                                Lastyear[2] += (int)item[4];
                                break;
                            case 4:
                                Lastyear[3] += (int)item[4];
                                break;
                        }
                    }
                    Seriesyear = new ObservableCollection<DataSeries>()
                {
                     new DataSeries
                              {
                                      Name = (SelectDatetimes.Year-1).ToString(),
                                      Values = new ObservableCollection<Comparepoint>()
                                      {
                                          new Comparepoint("Total", Lastyear[0]+Lastyear[1]+Lastyear[2]+Lastyear[3]),
                                          new Comparepoint("Model 1", Lastyear[0]),
                                          new Comparepoint("Model 2", Lastyear[1]),
                                          new Comparepoint("Model 3", Lastyear[2]),
                                          new Comparepoint("Model 4", Lastyear[3]),
                                      }
                              },
                              new DataSeries
                              {
                                     Name = SelectDatetimes.Year.ToString(),
                                     Values = new ObservableCollection<Comparepoint>()
                                     {

                                          new Comparepoint("Total", Thisyear[0]+Thisyear[1]+Thisyear[2]+Thisyear[3]),
                                          new Comparepoint("Model 1", Thisyear[0]),
                                          new Comparepoint("Model 2", Thisyear[1]),
                                          new Comparepoint("Model 3", Thisyear[2]),
                                          new Comparepoint("Model 4", Thisyear[3]),

                                     }
                              },


               };

                    Loading_Indicator.Finished();
                }
                catch (Exception ex)
                {
                    Loading_Indicator.Finished();
                    MessageBox.Show(ex.Message);
                   
                }
               
            });
            Click = new RelayCommand<object>((p) => { return true; }, (p) =>
            {

                try
                {
                    Loading_Indicator.BeingBusy();
                    list1 = new ObservableCollection<Classlist1>();
                    int[] SLkinhBaket;
                    int[] SL = new int[24];
                    int SLBasketX = 0;
                    double[] SLBaksetXPhantram = new double[2];
                    ModelBasket[0] = ModelBasket[1] = ModelBasket[2] = ModelBasket[3] = 0;
                    SLModel[0] = SLModel[1] = SLModel[2] = SLModel[3] = 0;
                    clasTablehoya1 = (TableHoya1)p;
                    SelectBasket = ("Total Basket " + clasTablehoya1.Basket + ":").ToString();
                   

                    string cmd = string.Empty;
                    string date = SelectDatetimes.ToString("yyyy-MM-dd");
                    cmd = "SELECT * FROM DateShift1 where Ngay = '" + date + "' ";
                    DataTable TableHoya1 = new DataTable();
                    TableHoya1 = Sqlexcute.Read_Table_Group(cmd);

                    if (TableHoya1.Rows.Count > 0)
                    {

                        foreach (DataRow item in TableHoya1.Rows)
                        {
                            if ((string)item[3] == clasTablehoya1.Basket)
                            {
                                SLBasketX++;
                                switch ((int)item[5])
                                {
                                    case 1:

                                        SLModel[0] += (int)item[4];

                                        ModelBasket[0]++;

                                        break;
                                    case 2:
                                        SLModel[1] += (int)item[4];

                                        ModelBasket[1]++;

                                        break;
                                    case 3:

                                        SLModel[2] += (int)item[4];

                                        ModelBasket[2]++;

                                        break;
                                    case 4:

                                        SLModel[3] += (int)item[4];

                                        ModelBasket[3]++;

                                        break;
                                }
                                list1.Add(new Classlist1() { Hour = (TimeSpan)item[2], Model = (int)item[5], Quantity = (int)item[4] });
                            }
                        }
                        #region a
                        //foreach (DataRow item in TableHoya1.Rows)
                        //{
                        //    if ((string)item[3] == clasTablehoya1.Basket)
                        //    {
                        //        countBaket++;
                        //    }

                        //}
                        //Arhourday = new TimeSpan[countBaket];
                        //SLkinhBaket = new int[countBaket];
                        //countBaket = 0;
                        //foreach (DataRow item in TableHoya1.Rows)
                        //{
                        //    if ((string)item[3] == clasTablehoya1.Basket)
                        //    {
                        //        Arhourday[countBaket] = (TimeSpan)item[2];
                        //        SLkinhBaket[countBaket] = (int)item[4];
                        //        countBaket++;
                        //    }

                        //}
                        #endregion
                    }

                    cmd = "SELECT * FROM DateShift3 where Ngay = '" + date + "' ";
                    TableHoya1 = Sqlexcute.Read_Table_Group(cmd);
                    if (TableHoya1.Rows.Count > 0)
                    {

                        foreach (DataRow item in TableHoya1.Rows)
                        {
                            if ((string)item[3] == clasTablehoya1.Basket)
                            {
                                SLBasketX++;
                                switch ((int)item[5])
                                {
                                    case 1:

                                        SLModel[0] += (int)item[4];

                                        ModelBasket[0]++;

                                        break;
                                    case 2:
                                        SLModel[1] += (int)item[4];

                                        ModelBasket[1]++;

                                        break;
                                    case 3:

                                        SLModel[2] += (int)item[4];

                                        ModelBasket[2]++;

                                        break;
                                    case 4:

                                        SLModel[3] += (int)item[4];

                                        ModelBasket[3]++;

                                        break;
                                }
                                list1.Add(new Classlist1() { Hour = (TimeSpan)item[2], Model = (int)item[5], Quantity = (int)item[4] });
                            }
                        }
                        #region a
                        //foreach (DataRow item in TableHoya1.Rows)
                        //{
                        //    if ((string)item[3] == clasTablehoya1.Basket)
                        //    {
                        //        countBaket++;
                        //    }

                        //}
                        //Arhourday = new TimeSpan[countBaket];
                        //SLkinhBaket = new int[countBaket];
                        //countBaket = 0;
                        //foreach (DataRow item in TableHoya1.Rows)
                        //{
                        //    if ((string)item[3] == clasTablehoya1.Basket)
                        //    {
                        //        Arhourday[countBaket] = (TimeSpan)item[2];
                        //        SLkinhBaket[countBaket] = (int)item[4];
                        //        countBaket++;
                        //    }

                        //}
                        #endregion
                    }

                    cmd = "SELECT * FROM DateShift2 where Ngay = '" + date + "' ";
                    TableHoya1 = Sqlexcute.Read_Table_Group(cmd);
                    if (TableHoya1.Rows.Count > 0)
                    {

                        foreach (DataRow item in TableHoya1.Rows)
                        {
                            if ((string)item[3] == clasTablehoya1.Basket)
                            {
                                SLBasketX++;
                                switch ((int)item[5])
                                {
                                    case 1:

                                        SLModel[0] += (int)item[4];

                                        ModelBasket[0]++;

                                        break;
                                    case 2:
                                        SLModel[1] += (int)item[4];

                                        ModelBasket[1]++;

                                        break;
                                    case 3:

                                        SLModel[2] += (int)item[4];

                                        ModelBasket[2]++;

                                        break;
                                    case 4:

                                        SLModel[3] += (int)item[4];

                                        ModelBasket[3]++;

                                        break;
                                }
                                list1.Add(new Classlist1() { Hour = (TimeSpan)item[2], Model = (int)item[5], Quantity = (int)item[4] });
                            }
                        }
                        #region a
                        //foreach (DataRow item in TableHoya1.Rows)
                        //{
                        //    if ((string)item[3] == clasTablehoya1.Basket)
                        //    {
                        //        countBaket++;
                        //    }

                        //}
                        //Arhourday = new TimeSpan[countBaket];
                        //SLkinhBaket = new int[countBaket];
                        //countBaket = 0;
                        //foreach (DataRow item in TableHoya1.Rows)
                        //{
                        //    if ((string)item[3] == clasTablehoya1.Basket)
                        //    {
                        //        Arhourday[countBaket] = (TimeSpan)item[2];
                        //        SLkinhBaket[countBaket] = (int)item[4];
                        //        countBaket++;
                        //    }

                        //}
                        #endregion
                    }

                    Arhourday = new TimeSpan[list1.Count];
                    SLkinhBaket = new int[list1.Count];
                    for (int i = 0; i < list1.Count; i++)
                    {
                        Arhourday[i] = (TimeSpan)list1[i].Hour;
                        SLkinhBaket[i] = (int)list1[i].Quantity;
                    }
                    SLBaksetXPhantram[0] = (double)SLBasketX / (double)SLBasket;
                    SLBaksetXPhantram[1] = 1 - SLBaksetXPhantram[0];
                    SLBasketXx = SLBasketX;
                    ProgressBasket = new ObservableCollection<OrderStatus>();
                    for (int i = 0; i < 2; i++)
                    {
                        ProgressBasket.Add(new OrderStatus() { Argument = ArgumentModel[i], Value = SLBaksetXPhantram[i] });

                    }
                    StatictisHourBasketModel = new ObservableCollection<OrderStatus1>();
                    for (int i = 0; i < Arhourday.Count(); i++)
                    {

                        StatictisHourBasketModel.Add(new OrderStatus1() { Argument = Arhourday[i], Value = SLkinhBaket[i] });
                    }
                    StatictisHourBasket = new ObservableCollection<OrderStatus>();
                    for (int i = 0; i < 4; i++)
                    {
                        StatictisHourBasket.Add(new OrderStatus() { Argument = ArgumentModel[i], Value = SLModel[i] });
                    }
                    Loading_Indicator.Finished();
                    BasketView basketView = new BasketView();
                    basketView.ShowDialog();
                }
                catch (Exception ex)
                {

                    Loading_Indicator.Finished();
                    MessageBox.Show(ex.Message);
                }
              
            });
            ApplyShiftcommand = new RelayCommand<object>((p) => { return true; }, (p) =>
            {
                try
                {
                    int[] TotalBasket = new int[2];
                    int[] _SLModel = new int[4];
                    string[] SSTongShift = new string[] { "Total", "Total Shift" };
                    double[] TotalBasketPhantram = new double[2];
                    double[] _SLModelPhantram = new double[8];
                    SLModel[0] = SLModel[1] = SLModel[2] = SLModel[3] = 0;
                    int[] valuedayShit = new int[8];
                    int[] WordTime = new int[2];
                    int[] SSTotalShift = new int[2];
                    string[] TimeLV = new string[] { "OEE", "NOEE" };
                    listShift = new ObservableCollection<classlistshift>();
                    string cmd = string.Empty;
                    string date = SelectDatetimes.ToString("yyyy-MM-dd");
                    if (IndexShift == 0)
                    {
                        Loading_Indicator.BeingBusy();
                        Shift = "Shift 1";
                        cmd = "SELECT * FROM DateShift1 where Ngay = '" + date + "' ";
                        DataTable TableHoya1 = new DataTable();
                        TableHoya1 = Sqlexcute.Read_Table_Group(cmd);
                        if (TableHoya1.Rows.Count > 0)
                        {
                            foreach (DataRow item in TableHoya1.Rows)
                            {
                                listShift.Add(new classlistshift() { Hour = (TimeSpan)item[2], Basket = (string)item[3], Model = (int)item[5], Quantity = (int)item[4] });
                                switch ((int)item[5])
                                {
                                    case 1:
                                        TotalBasket[0]++;
                                        TotalBasket[1]++;
                                        _SLModel[0] += (int)item[4];
                                        SLModel[0] += (int)item[4];
                                        break;
                                    case 2:
                                        TotalBasket[0]++;
                                        TotalBasket[1]++;

                                        _SLModel[1] += (int)item[4];
                                        SLModel[1] += (int)item[4];
                                        break;
                                    case 3:
                                        TotalBasket[0]++;
                                        TotalBasket[1]++;
                                        _SLModel[2] += (int)item[4];
                                        SLModel[2] += (int)item[4];
                                        break;
                                    case 4:

                                        TotalBasket[0]++;
                                        TotalBasket[1]++;

                                        _SLModel[3] += (int)item[4];
                                        SLModel[3] += (int)item[4];
                                        break;
                                }

                                TimeSpan hour = (TimeSpan)item[2];
                                switch (hour.Hours)
                                {
                                    case 8:
                                        valuedayShit[0] += (int)item[4];
                                        break;
                                    case 9:
                                        valuedayShit[1] += (int)item[4];
                                        break;
                                    case 10:
                                        valuedayShit[2] += (int)item[4];
                                        break;
                                    case 11:
                                        valuedayShit[3] += (int)item[4];
                                        break;
                                    case 12:
                                        valuedayShit[4] += (int)item[4];
                                        break;
                                    case 13:
                                        valuedayShit[5] += (int)item[4];
                                        break;
                                    case 14:
                                        valuedayShit[6] += (int)item[4];
                                        break;
                                    case 15:
                                        valuedayShit[7] += (int)item[4];
                                        break;
                                }
                            }
                        }
                        cmd = "SELECT * FROM DateShift2 where Ngay = '" + date + "' ";
                        TableHoya1 = Sqlexcute.Read_Table_Group(cmd);
                        if (TableHoya1.Rows.Count > 0)
                        {
                            foreach (DataRow item in TableHoya1.Rows)
                            {
                                switch ((int)item[5])
                                {
                                    case 1:
                                        TotalBasket[0]++;
                                        _SLModel[0] += (int)item[4];
                                        break;
                                    case 2:
                                        TotalBasket[0]++;
                                        _SLModel[1] += (int)item[4];
                                        break;
                                    case 3:
                                        TotalBasket[0]++;
                                        _SLModel[2] += (int)item[4];
                                        break;
                                    case 4:
                                        TotalBasket[0]++;
                                        _SLModel[3] += (int)item[4];
                                        break;
                                }
                            }
                        }
                        cmd = "SELECT * FROM DateShift3 where Ngay = '" + date + "' ";
                        TableHoya1 = Sqlexcute.Read_Table_Group(cmd);
                        if (TableHoya1.Rows.Count > 0)
                        {
                            foreach (DataRow item in TableHoya1.Rows)
                            {
                                switch ((int)item[5])
                                {
                                    case 1:
                                        TotalBasket[0]++;
                                        _SLModel[0] += (int)item[4];
                                        break;
                                    case 2:
                                        TotalBasket[0]++;
                                        _SLModel[1] += (int)item[4];
                                        break;
                                    case 3:
                                        TotalBasket[0]++;
                                        _SLModel[2] += (int)item[4];
                                        break;
                                    case 4:
                                        TotalBasket[0]++;
                                        _SLModel[3] += (int)item[4];
                                        break;
                                }
                            }
                        }
                        TotalBasketPhantram[1] = (double)TotalBasket[1] / (double)TotalBasket[0];
                        TotalBasketPhantram[0] = 1 - TotalBasketPhantram[1];
                        _SLModelPhantram[1] = (double)SLModel[0] / (double)_SLModel[0];
                        _SLModelPhantram[0] = 1 - _SLModelPhantram[1];
                        _SLModelPhantram[3] = (double)SLModel[1] / (double)_SLModel[1];
                        _SLModelPhantram[2] = 1 - _SLModelPhantram[3];
                        _SLModelPhantram[5] = (double)SLModel[2] / (double)_SLModel[2];
                        _SLModelPhantram[4] = 1 - _SLModelPhantram[5];
                        _SLModelPhantram[7] = (double)SLModel[3] / (double)_SLModel[3];
                        _SLModelPhantram[6] = 1 - _SLModelPhantram[7];
                        a = TotalBasket[1];
                        b = TotalBasket[0];
                        c = SLModel[0];
                        d = _SLModel[0];
                        e = SLModel[1];
                        f = _SLModel[1];
                        g = SLModel[2];
                        h = _SLModel[2];
                        i = SLModel[3];
                        k = _SLModel[3];
                        ProgressShif1 = new ObservableCollection<OrderStatus>();
                        for (int i = 0; i < 2; i++)
                        {
                            ProgressShif1.Add(new OrderStatus() { Argument = SSTongShift[i], Value = TotalBasketPhantram[i] });
                        }
                        ProgressShift2 = new ObservableCollection<OrderStatus>
                        {
                            new OrderStatus() { Argument = SSTongShift[0], Value = _SLModelPhantram[0] },
                            new OrderStatus() { Argument = SSTongShift[1], Value = _SLModelPhantram[1] }
                        };

                        ProgressShift3 = new ObservableCollection<OrderStatus>
                        {
                            new OrderStatus() { Argument = SSTongShift[0], Value = _SLModelPhantram[2] },
                            new OrderStatus() { Argument = SSTongShift[1], Value = _SLModelPhantram[3] }
                        };

                        ProgressShift4 = new ObservableCollection<OrderStatus>
                        {
                            new OrderStatus() { Argument = SSTongShift[0], Value = _SLModelPhantram[4] },
                            new OrderStatus() { Argument = SSTongShift[1], Value = _SLModelPhantram[5] }
                        };

                        ProgressShift5 = new ObservableCollection<OrderStatus>
                        {
                            new OrderStatus() { Argument = SSTongShift[0], Value = _SLModelPhantram[6] },
                            new OrderStatus() { Argument = SSTongShift[1], Value = _SLModelPhantram[7] }
                        };

                        StatictisHourShift1 = new ObservableCollection<OrderStatus>();
                        for (int i = 0; i < 8; i++)
                        {
                            StatictisHourShift1.Add(new OrderStatus() { Argument = Argumenthourday[i + 8], Value = valuedayShit[i] });
                            if (valuedayShit[i] > 0)
                            {
                                WordTime[0]++;
                            }
                        }
                        WordTime[1] = 8 - WordTime[0];
                        ProgressShiftTime = new ObservableCollection<OrderStatus>();
                        for (int i = 0; i < 2; i++)
                        {
                            ProgressShiftTime.Add(new OrderStatus() { Argument = TimeLV[i], Value = WordTime[i] });
                        }

                        SSTotalShift[1] = SLModel[0] + SLModel[1] + SLModel[2] + SLModel[3];
                        SSTotalShift[0] = _SLModel[0] + _SLModel[1] + _SLModel[2] + _SLModel[3] - SSTotalShift[1];
                        l = SSTotalShift[1];
                        m = SSTotalShift[0] + SSTotalShift[1];
                        ProgressShiftTotalSL = new ObservableCollection<OrderStatus>();
                        for (int i = 0; i < 2; i++)
                        {
                            ProgressShiftTotalSL.Add(new OrderStatus() { Argument = SSTongShift[i], Value = SSTotalShift[i] });
                        }
                    }
                    else if (IndexShift == 1)
                    {
                        Loading_Indicator.BeingBusy();
                        Shift = "Shift 2";
                        cmd = "SELECT * FROM DateShift2 where Ngay = '" + date + "' ";
                        DataTable TableHoya1 = new DataTable();
                        TableHoya1 = Sqlexcute.Read_Table_Group(cmd);
                        if (TableHoya1.Rows.Count > 0)
                        {
                            foreach (DataRow item in TableHoya1.Rows)
                            {
                                listShift.Add(new classlistshift() { Hour = (TimeSpan)item[2], Basket = (string)item[3], Model = (int)item[5], Quantity = (int)item[4] });
                                switch ((int)item[5])
                                {
                                    case 1:
                                        TotalBasket[0]++;
                                        TotalBasket[1]++;
                                        _SLModel[0] += (int)item[4];
                                        SLModel[0] += (int)item[4];
                                        break;
                                    case 2:
                                        TotalBasket[0]++;
                                        TotalBasket[1]++;

                                        _SLModel[1] += (int)item[4];
                                        SLModel[1] += (int)item[4];
                                        break;
                                    case 3:
                                        TotalBasket[0]++;
                                        TotalBasket[1]++;
                                        _SLModel[2] += (int)item[4];
                                        SLModel[2] += (int)item[4];
                                        break;
                                    case 4:

                                        TotalBasket[0]++;
                                        TotalBasket[1]++;

                                        _SLModel[3] += (int)item[4];
                                        SLModel[3] += (int)item[4];
                                        break;
                                }

                                TimeSpan hour = (TimeSpan)item[2];
                                switch (hour.Hours)
                                {
                                    case 16:
                                        valuedayShit[0] += (int)item[4];
                                        break;
                                    case 17:
                                        valuedayShit[1] += (int)item[4];
                                        break;
                                    case 18:
                                        valuedayShit[2] += (int)item[4];
                                        break;
                                    case 19:
                                        valuedayShit[3] += (int)item[4];
                                        break;
                                    case 20:
                                        valuedayShit[4] += (int)item[4];
                                        break;
                                    case 21:
                                        valuedayShit[5] += (int)item[4];
                                        break;
                                    case 22:
                                        valuedayShit[6] += (int)item[4];
                                        break;
                                    case 23:
                                        valuedayShit[7] += (int)item[4];
                                        break;
                                }

                            }
                        }
                        cmd = "SELECT * FROM DateShift1 where Ngay = '" + date + "' ";
                        TableHoya1 = Sqlexcute.Read_Table_Group(cmd);
                        if (TableHoya1.Rows.Count > 0)
                        {
                            foreach (DataRow item in TableHoya1.Rows)
                            {
                                switch ((int)item[5])
                                {
                                    case 1:
                                        TotalBasket[0]++;
                                        _SLModel[0] += (int)item[4];
                                        break;
                                    case 2:
                                        TotalBasket[0]++;
                                        _SLModel[1] += (int)item[4];
                                        break;
                                    case 3:
                                        TotalBasket[0]++;
                                        _SLModel[2] += (int)item[4];
                                        break;
                                    case 4:
                                        TotalBasket[0]++;
                                        _SLModel[3] += (int)item[4];
                                        break;
                                }
                            }
                        }
                        cmd = "SELECT * FROM DateShift3 where Ngay = '" + date + "' ";
                        TableHoya1 = Sqlexcute.Read_Table_Group(cmd);
                        if (TableHoya1.Rows.Count > 0)
                        {
                            foreach (DataRow item in TableHoya1.Rows)
                            {
                                switch ((int)item[5])
                                {
                                    case 1:
                                        TotalBasket[0]++;
                                        _SLModel[0] += (int)item[4];
                                        break;
                                    case 2:
                                        TotalBasket[0]++;
                                        _SLModel[1] += (int)item[4];
                                        break;
                                    case 3:
                                        TotalBasket[0]++;
                                        _SLModel[2] += (int)item[4];
                                        break;
                                    case 4:
                                        TotalBasket[0]++;
                                        _SLModel[3] += (int)item[4];
                                        break;
                                }
                            }
                        }
                        TotalBasketPhantram[1] = (double)TotalBasket[1] / (double)TotalBasket[0];
                        TotalBasketPhantram[0] = 1 - TotalBasketPhantram[1];
                        _SLModelPhantram[1] = (double)SLModel[0] / (double)_SLModel[0];
                        _SLModelPhantram[0] = 1 - _SLModelPhantram[1];
                        _SLModelPhantram[3] = (double)SLModel[1] / (double)_SLModel[1];
                        _SLModelPhantram[2] = 1 - _SLModelPhantram[3];
                        _SLModelPhantram[5] = (double)SLModel[2] / (double)_SLModel[2];
                        _SLModelPhantram[4] = 1 - _SLModelPhantram[5];
                        _SLModelPhantram[7] = (double)SLModel[3] / (double)_SLModel[3];
                        _SLModelPhantram[6] = 1 - _SLModelPhantram[7];
                        a = TotalBasket[1];
                        b = TotalBasket[0];
                        c = SLModel[0];
                        d = _SLModel[0];
                        e = SLModel[1];
                        f = _SLModel[1];
                        g = SLModel[2];
                        h = _SLModel[2];
                        i = SLModel[3];
                        k = _SLModel[3];
                        ProgressShif1 = new ObservableCollection<OrderStatus>();
                        for (int i = 0; i < 2; i++)
                        {
                            ProgressShif1.Add(new OrderStatus() { Argument = SSTongShift[i], Value = TotalBasketPhantram[i] });
                        }
                        ProgressShift2 = new ObservableCollection<OrderStatus>
                        {
                            new OrderStatus() { Argument = SSTongShift[0], Value = _SLModelPhantram[0] },
                            new OrderStatus() { Argument = SSTongShift[1], Value = _SLModelPhantram[1] }
                        };

                        ProgressShift3 = new ObservableCollection<OrderStatus>
                        {
                            new OrderStatus() { Argument = SSTongShift[0], Value = _SLModelPhantram[2] },
                            new OrderStatus() { Argument = SSTongShift[1], Value = _SLModelPhantram[3] }
                        };

                        ProgressShift4 = new ObservableCollection<OrderStatus>
                        {
                            new OrderStatus() { Argument = SSTongShift[0], Value = _SLModelPhantram[4] },
                            new OrderStatus() { Argument = SSTongShift[1], Value = _SLModelPhantram[5] }
                        };

                        ProgressShift5 = new ObservableCollection<OrderStatus>
                        {
                            new OrderStatus() { Argument = SSTongShift[0], Value = _SLModelPhantram[6] },
                            new OrderStatus() { Argument = SSTongShift[1], Value = _SLModelPhantram[7] }
                        };

                        StatictisHourShift1 = new ObservableCollection<OrderStatus>();
                        for (int i = 0; i < 8; i++)
                        {
                            StatictisHourShift1.Add(new OrderStatus() { Argument = Argumenthourday[i + 16], Value = valuedayShit[i] });
                            if (valuedayShit[i] > 0)
                            {
                                WordTime[0]++;
                            }
                        }
                        WordTime[1] = 8 - WordTime[0];
                        ProgressShiftTime = new ObservableCollection<OrderStatus>();
                        for (int i = 0; i < 2; i++)
                        {
                            ProgressShiftTime.Add(new OrderStatus() { Argument = TimeLV[i], Value = WordTime[i] });
                        }
                        SSTotalShift[1] = SLModel[0] + SLModel[1] + SLModel[2] + SLModel[3];
                        SSTotalShift[0] = _SLModel[0] + _SLModel[1] + _SLModel[2] + _SLModel[3] - SSTotalShift[1];
                        l = SSTotalShift[1];
                        m = SSTotalShift[0] + SSTotalShift[1];
                        ProgressShiftTotalSL = new ObservableCollection<OrderStatus>();
                        for (int i = 0; i < 2; i++)
                        {
                            ProgressShiftTotalSL.Add(new OrderStatus() { Argument = SSTongShift[i], Value = SSTotalShift[i] });
                        }
                    }
                    else if (IndexShift == 2)
                    {
                        Loading_Indicator.BeingBusy();
                        Shift = "Shift 3";
                        cmd = "SELECT * FROM DateShift3 where Ngay = '" + date + "' ";
                        DataTable TableHoya1 = new DataTable();
                        TableHoya1 = Sqlexcute.Read_Table_Group(cmd);
                        if (TableHoya1.Rows.Count > 0)
                        {
                            foreach (DataRow item in TableHoya1.Rows)
                            {
                                listShift.Add(new classlistshift() { Hour = (TimeSpan)item[2], Basket = (string)item[3], Model = (int)item[5], Quantity = (int)item[4] });
                                switch ((int)item[5])
                                {
                                    case 1:
                                        TotalBasket[0]++;
                                        TotalBasket[1]++;
                                        _SLModel[0] += (int)item[4];
                                        SLModel[0] += (int)item[4];
                                        break;
                                    case 2:
                                        TotalBasket[0]++;
                                        TotalBasket[1]++;

                                        _SLModel[1] += (int)item[4];
                                        SLModel[1] += (int)item[4];
                                        break;
                                    case 3:
                                        TotalBasket[0]++;
                                        TotalBasket[1]++;
                                        _SLModel[2] += (int)item[4];
                                        SLModel[2] += (int)item[4];
                                        break;
                                    case 4:

                                        TotalBasket[0]++;
                                        TotalBasket[1]++;

                                        _SLModel[3] += (int)item[4];
                                        SLModel[3] += (int)item[4];
                                        break;
                                }
                                TimeSpan hour = (TimeSpan)item[2];
                                switch (hour.Hours)
                                {
                                    case 0:
                                        valuedayShit[0] += (int)item[4];
                                        break;
                                    case 1:
                                        valuedayShit[1] += (int)item[4];
                                        break;
                                    case 2:
                                        valuedayShit[2] += (int)item[4];
                                        break;
                                    case 3:
                                        valuedayShit[3] += (int)item[4];
                                        break;
                                    case 4:
                                        valuedayShit[4] += (int)item[4];
                                        break;
                                    case 5:
                                        valuedayShit[5] += (int)item[4];
                                        break;
                                    case 6:
                                        valuedayShit[6] += (int)item[4];
                                        break;
                                    case 7:
                                        valuedayShit[7] += (int)item[4];
                                        break;
                                }

                            }
                        }
                        cmd = "SELECT * FROM DateShift2 where Ngay = '" + date + "' ";
                        TableHoya1 = Sqlexcute.Read_Table_Group(cmd);
                        if (TableHoya1.Rows.Count > 0)
                        {
                            foreach (DataRow item in TableHoya1.Rows)
                            {
                                switch ((int)item[5])
                                {
                                    case 1:
                                        TotalBasket[0]++;
                                        _SLModel[0] += (int)item[4];
                                        break;
                                    case 2:
                                        TotalBasket[0]++;
                                        _SLModel[1] += (int)item[4];
                                        break;
                                    case 3:
                                        TotalBasket[0]++;
                                        _SLModel[2] += (int)item[4];
                                        break;
                                    case 4:
                                        TotalBasket[0]++;
                                        _SLModel[3] += (int)item[4];
                                        break;
                                }
                            }
                        }
                        cmd = "SELECT * FROM DateShift1 where Ngay = '" + date + "' ";
                        TableHoya1 = Sqlexcute.Read_Table_Group(cmd);
                        if (TableHoya1.Rows.Count > 0)
                        {
                            foreach (DataRow item in TableHoya1.Rows)
                            {
                                switch ((int)item[5])
                                {
                                    case 1:
                                        TotalBasket[0]++;
                                        _SLModel[0] += (int)item[4];
                                        break;
                                    case 2:
                                        TotalBasket[0]++;
                                        _SLModel[1] += (int)item[4];
                                        break;
                                    case 3:
                                        TotalBasket[0]++;
                                        _SLModel[2] += (int)item[4];
                                        break;
                                    case 4:
                                        TotalBasket[0]++;
                                        _SLModel[3] += (int)item[4];
                                        break;
                                }
                            }
                        }
                        TotalBasketPhantram[1] = (double)TotalBasket[1] / (double)TotalBasket[0];
                        TotalBasketPhantram[0] = 1 - TotalBasketPhantram[1];
                        _SLModelPhantram[1] = (double)SLModel[0] / (double)_SLModel[0];
                        _SLModelPhantram[0] = 1 - _SLModelPhantram[1];
                        _SLModelPhantram[3] = (double)SLModel[1] / (double)_SLModel[1];
                        _SLModelPhantram[2] = 1 - _SLModelPhantram[3];
                        _SLModelPhantram[5] = (double)SLModel[2] / (double)_SLModel[2];
                        _SLModelPhantram[4] = 1 - _SLModelPhantram[5];
                        _SLModelPhantram[7] = (double)SLModel[3] / (double)_SLModel[3];
                        _SLModelPhantram[6] = 1 - _SLModelPhantram[7];
                        a = TotalBasket[1];
                        b = TotalBasket[0];
                        c = SLModel[0];
                        d = _SLModel[0];
                        e = SLModel[1];
                        f = _SLModel[1];
                        g = SLModel[2];
                        h = _SLModel[2];
                        i = SLModel[3];
                        k = _SLModel[3];
                        ProgressShif1 = new ObservableCollection<OrderStatus>();
                        for (int i = 0; i < 2; i++)
                        {
                            ProgressShif1.Add(new OrderStatus() { Argument = SSTongShift[i], Value = TotalBasketPhantram[i] });
                        }
                        ProgressShift2 = new ObservableCollection<OrderStatus>
                        {
                            new OrderStatus() { Argument = SSTongShift[0], Value = _SLModelPhantram[0] },
                            new OrderStatus() { Argument = SSTongShift[1], Value = _SLModelPhantram[1] }
                        };

                        ProgressShift3 = new ObservableCollection<OrderStatus>
                        {
                            new OrderStatus() { Argument = SSTongShift[0], Value = _SLModelPhantram[2] },
                            new OrderStatus() { Argument = SSTongShift[1], Value = _SLModelPhantram[3] }
                        };

                        ProgressShift4 = new ObservableCollection<OrderStatus>
                        {
                            new OrderStatus() { Argument = SSTongShift[0], Value = _SLModelPhantram[4] },
                            new OrderStatus() { Argument = SSTongShift[1], Value = _SLModelPhantram[5] }
                        };

                        ProgressShift5 = new ObservableCollection<OrderStatus>
                        {
                            new OrderStatus() { Argument = SSTongShift[0], Value = _SLModelPhantram[6] },
                            new OrderStatus() { Argument = SSTongShift[1], Value = _SLModelPhantram[7] }
                        };
                        StatictisHourShift1 = new ObservableCollection<OrderStatus>();
                        for (int i = 0; i < 8; i++)
                        {
                            StatictisHourShift1.Add(new OrderStatus() { Argument = Argumenthourday[i], Value = valuedayShit[i] });
                            if (valuedayShit[i] > 0)
                            {
                                WordTime[0]++;
                            }
                        }
                        WordTime[1] = 8 - WordTime[0];
                        ProgressShiftTime = new ObservableCollection<OrderStatus>();
                        for (int i = 0; i < 2; i++)
                        {
                            ProgressShiftTime.Add(new OrderStatus() { Argument = TimeLV[i], Value = WordTime[i] });
                        }
                        SSTotalShift[1] = SLModel[0] + SLModel[1] + SLModel[2] + SLModel[3];
                        SSTotalShift[0] = _SLModel[0] + _SLModel[1] + _SLModel[2] + _SLModel[3] - SSTotalShift[1];
                        l = SSTotalShift[1];
                        m = SSTotalShift[0] + SSTotalShift[1];
                        ProgressShiftTotalSL = new ObservableCollection<OrderStatus>();
                        for (int i = 0; i < 2; i++)
                        {
                            ProgressShiftTotalSL.Add(new OrderStatus() { Argument = SSTongShift[i], Value = SSTotalShift[i] });
                        }
                    }


                    StatictisHourShift = new ObservableCollection<OrderStatus>();
                    for (int i = 0; i < 4; i++)
                    {
                        StatictisHourShift.Add(new OrderStatus() { Argument = ArgumentModel[i], Value = SLModel[i] });
                    }

                    date = SelectDatetimes.AddDays(-1).ToString("yyyy-MM-dd");
                    if (IndexShift == 0)
                    {
                        valuedayShit = new int[8];
                        cmd = "SELECT * FROM DateShift1 where Ngay = '" + date + "' ";
                        DataTable TableHoya1 = new DataTable();
                        TableHoya1 = Sqlexcute.Read_Table_Group(cmd);
                        foreach (DataRow item in TableHoya1.Rows)
                        {
                            TimeSpan hour = (TimeSpan)item[2];
                            switch (hour.Hours)
                            {
                                case 8:
                                    valuedayShit[0] += (int)item[4];
                                    break;
                                case 9:
                                    valuedayShit[1] += (int)item[4];
                                    break;
                                case 10:
                                    valuedayShit[2] += (int)item[4];
                                    break;
                                case 11:
                                    valuedayShit[3] += (int)item[4];
                                    break;
                                case 12:
                                    valuedayShit[4] += (int)item[4];
                                    break;
                                case 13:
                                    valuedayShit[5] += (int)item[4];
                                    break;
                                case 14:
                                    valuedayShit[6] += (int)item[4];
                                    break;
                                case 15:
                                    valuedayShit[7] += (int)item[4];
                                    break;
                            }
                        }
                        YesterdayStatictisHourShift1 = new ObservableCollection<OrderStatus>();
                        for (int i = 0; i < 8; i++)
                        {
                            YesterdayStatictisHourShift1.Add(new OrderStatus() { Argument = Argumenthourday[i + 8], Value = valuedayShit[i] });

                        }
                    }
                    if (IndexShift == 1)
                    {
                        valuedayShit = new int[8];
                        cmd = "SELECT * FROM DateShift2 where Ngay = '" + date + "' ";
                        DataTable TableHoya1 = new DataTable();
                        TableHoya1 = Sqlexcute.Read_Table_Group(cmd);
                        foreach (DataRow item in TableHoya1.Rows)
                        {
                            TimeSpan hour = (TimeSpan)item[2];
                            switch (hour.Hours)
                            {
                                case 16:
                                    valuedayShit[0] += (int)item[4];
                                    break;
                                case 17:
                                    valuedayShit[1] += (int)item[4];
                                    break;
                                case 18:
                                    valuedayShit[2] += (int)item[4];
                                    break;
                                case 19:
                                    valuedayShit[3] += (int)item[4];
                                    break;
                                case 20:
                                    valuedayShit[4] += (int)item[4];
                                    break;
                                case 21:
                                    valuedayShit[5] += (int)item[4];
                                    break;
                                case 22:
                                    valuedayShit[6] += (int)item[4];
                                    break;
                                case 23:
                                    valuedayShit[7] += (int)item[4];
                                    break;
                            }
                        }
                        YesterdayStatictisHourShift1 = new ObservableCollection<OrderStatus>();
                        for (int i = 0; i < 8; i++)
                        {
                            YesterdayStatictisHourShift1.Add(new OrderStatus() { Argument = Argumenthourday[i + 16], Value = valuedayShit[i] });

                        }
                    }
                    if (IndexShift == 2)
                    {
                        valuedayShit = new int[8];
                        cmd = "SELECT * FROM DateShift3 where Ngay = '" + date + "' ";
                        DataTable TableHoya1 = new DataTable();
                        TableHoya1 = Sqlexcute.Read_Table_Group(cmd);
                        foreach (DataRow item in TableHoya1.Rows)
                        {
                            TimeSpan hour = (TimeSpan)item[2];
                            switch (hour.Hours)
                            {
                                case 0:
                                    valuedayShit[0] += (int)item[4];
                                    break;
                                case 1:
                                    valuedayShit[1] += (int)item[4];
                                    break;
                                case 2:
                                    valuedayShit[2] += (int)item[4];
                                    break;
                                case 3:
                                    valuedayShit[3] += (int)item[4];
                                    break;
                                case 4:
                                    valuedayShit[4] += (int)item[4];
                                    break;
                                case 5:
                                    valuedayShit[5] += (int)item[4];
                                    break;
                                case 6:
                                    valuedayShit[6] += (int)item[4];
                                    break;
                                case 7:
                                    valuedayShit[7] += (int)item[4];
                                    break;
                            }
                        }
                        YesterdayStatictisHourShift1 = new ObservableCollection<OrderStatus>();
                        for (int i = 0; i < 8; i++)
                        {
                            YesterdayStatictisHourShift1.Add(new OrderStatus() { Argument = Argumenthourday[i], Value = valuedayShit[i] });

                        }
                    }

                    //////

                    Loading_Indicator.Finished();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    Loading_Indicator.Finished();
                }

            });
            ThisMonth = new RelayCommand<object>((p) => { return true; }, (p) =>
            {
                try
                {
                    Loading_Indicator.BeingBusy();
                    QtyThismonth = 0;
                    slthismonth = sllastmonth = 0;
                    int[] ModelMonth = new int[4];
                    string[] ssTL = new string[] { "Last Month", "This Month" };

                    DateTime today = DateTime.Today;
                    month = today.ToString("MM/yyyy");
                    List<DateTime> listdate = new List<DateTime>();
                    string cmd = string.Empty;
                    string date = today.ToString("yyyy-MM-dd");
                    cmd = "SELECT * FROM DateShift1 WHERE MONTH(Ngay) = MONTH(" + "\" " + date + "\"" + ") and year(Ngay)=year(" + "\" " + date + "\"" + ")";
                    cmd = cmd.Replace(@"\", "");
                    DataTable TableHoya1 = new DataTable();
                    TableHoya1 = Sqlexcute.Read_Table_Group(cmd);
                    cmd = "SELECT * FROM DateShift2 WHERE MONTH(Ngay) = MONTH(" + "\" " + date + "\"" + ") and year(Ngay)=year(" + "\" " + date + "\"" + ")";
                    cmd = cmd.Replace(@"\", "");
                    DataTable TableHoya2 = new DataTable();
                    TableHoya2 = Sqlexcute.Read_Table_Group(cmd);
                    cmd = "SELECT * FROM DateShift3 WHERE MONTH(Ngay) = MONTH(" + "\" " + date + "\"" + ") and year(Ngay)=year(" + "\" " + date + "\"" + ")";
                    cmd = cmd.Replace(@"\", "");
                    DataTable TableHoya3 = new DataTable();
                    TableHoya3 = Sqlexcute.Read_Table_Group(cmd);
                    foreach (DataRow item in TableHoya2.Rows)
                    {
                        TableHoya1.Rows.Add(item.ItemArray);
                    }
                    foreach (DataRow item in TableHoya3.Rows)
                    {
                        TableHoya1.Rows.Add(item.ItemArray);
                    }

                    foreach (DataRow item in TableHoya1.Rows)
                    {
                        DateTime tem = (DateTime)item[1];
                        string tempdate = tem.ToString("yyyy-MM-dd");
                        if (!listdate.Contains(tem))
                        {
                            listdate.Add(tem);
                        }
                        valuedaymonth = new int[listdate.Count];
                    }
                    listdate.Sort();
                    foreach (DataRow item in TableHoya1.Rows)
                    {
                        for (int i = 0; i < listdate.Count; i++)
                        {
                            if ((DateTime)item[1] == listdate[i])
                            {
                                valuedaymonth[i] += (int)item[4];
                                switch ((int)item[5])
                                {
                                    case 1:
                                        ModelMonth[0] += (int)item[4];
                                        break;
                                    case 2:
                                        ModelMonth[1] += (int)item[4];
                                        break;
                                    case 3:
                                        ModelMonth[2] += (int)item[4];
                                        break;
                                    case 4:
                                        ModelMonth[3] += (int)item[4];
                                        break;
                                }
                            }
                        }
                    }
                    DataProductMonth = new ObservableCollection<OrderStatus>();
                    for (int i = 0; i < listdate.Count; i++)
                    {
                        DataProductMonth.Add(new OrderStatus() { Argument = listdate[i].ToString("yyyy-MM-dd"), Value = valuedaymonth[i] });
                        slthismonth += valuedaymonth[i];
                        QtyThismonth += valuedaymonth[i];
                        slmonth = slthismonth;

                    }
                    /////processmodelslmonth
                    ProgressModelSLMonth = new ObservableCollection<OrderStatus>();
                    for (int i = 0; i < 4; i++)
                    {
                        ProgressModelSLMonth.Add(new OrderStatus() { Argument = ArgumentModel[i], Value = ModelMonth[i] });

                    }

                    ////////////// sl látmonth
                    listdate = new List<DateTime>();
                    date = today.AddMonths(-1).ToString("yyyy-MM-dd");
                    cmd = "SELECT * FROM DateShift1 WHERE MONTH(Ngay) = MONTH(" + "\" " + date + "\"" + ") and year(Ngay)=year(" + "\" " + date + "\"" + ")";
                    cmd = cmd.Replace(@"\", "");

                    TableHoya1 = Sqlexcute.Read_Table_Group(cmd);
                    cmd = "SELECT * FROM DateShift2 WHERE MONTH(Ngay) = MONTH(" + "\" " + date + "\"" + ") and year(Ngay)=year(" + "\" " + date + "\"" + ")";
                    cmd = cmd.Replace(@"\", "");

                    TableHoya2 = Sqlexcute.Read_Table_Group(cmd);
                    cmd = "SELECT * FROM DateShift3 WHERE MONTH(Ngay) = MONTH(" + "\" " + date + "\"" + ") and year(Ngay)=year(" + "\" " + date + "\"" + ")";
                    cmd = cmd.Replace(@"\", "");

                    TableHoya3 = Sqlexcute.Read_Table_Group(cmd);
                    foreach (DataRow item in TableHoya2.Rows)
                    {
                        TableHoya1.Rows.Add(item.ItemArray);
                    }
                    foreach (DataRow item in TableHoya3.Rows)
                    {
                        TableHoya1.Rows.Add(item.ItemArray);
                    }

                    foreach (DataRow item in TableHoya1.Rows)
                    {
                        DateTime tem = (DateTime)item[1];
                        string tempdate = tem.ToString("yyyy-MM-dd");
                        if (!listdate.Contains(tem))
                        {
                            listdate.Add(tem);
                        }
                        valuedaymonth = new int[listdate.Count];
                    }
                    listdate.Sort();
                    foreach (DataRow item in TableHoya1.Rows)
                    {
                        for (int i = 0; i < listdate.Count; i++)
                        {
                            if ((DateTime)item[1] == listdate[i])
                            {
                                sllastmonth += (int)item[4];
                            }
                        }
                    }
                    if (slthismonth > sllastmonth)
                    {
                        string Systemconfigmagetangday = System.IO.Directory.GetCurrentDirectory() + @"\" + @"image\trendUp.png";

                        ImgTangmonth = Systemconfigmagetangday;
                    }
                    else if (slthismonth < sllastmonth)
                    {
                        string Systemconfigmagetangday = System.IO.Directory.GetCurrentDirectory() + @"\" + @"image\trenDown.png";

                        ImgTangmonth = Systemconfigmagetangday;

                    }
                    else
                    {
                        ImgTangmonth = null;
                    }

                    Loading_Indicator.Finished();
                }
                catch (Exception ex)
                {
                    Loading_Indicator.Finished();
                    MessageBox.Show(ex.Message);
                }
                
            });
            LastMonth = new RelayCommand<object>((p) => { return true; }, (p) =>
            {
                try
                {
                    Loading_Indicator.BeingBusy();
                    QtyThismonth = 0;
                    sllastmonth = slthismonth = 0;
                    int[] ModelMonth = new int[4];

                    DateTime today = DateTime.Today;
                    month = today.AddMonths(-1).ToString("MM/yyyy");
                    List<DateTime> listdate = new List<DateTime>();
                    string cmd = string.Empty;
                    string date = today.AddMonths(-1).ToString("yyyy-MM-dd");
                    cmd = "SELECT * FROM DateShift1 WHERE MONTH(Ngay) = MONTH(" + "\" " + date + "\"" + ") and year(Ngay)=year(" + "\" " + date + "\"" + ")";
                    cmd = cmd.Replace(@"\", "");
                    DataTable TableHoya1 = new DataTable();
                    TableHoya1 = Sqlexcute.Read_Table_Group(cmd);
                    cmd = "SELECT * FROM DateShift2 WHERE MONTH(Ngay) = MONTH(" + "\" " + date + "\"" + ") and year(Ngay)=year(" + "\" " + date + "\"" + ")";
                    cmd = cmd.Replace(@"\", "");
                    DataTable TableHoya2 = new DataTable();
                    TableHoya2 = Sqlexcute.Read_Table_Group(cmd);
                    cmd = "SELECT * FROM DateShift3 WHERE MONTH(Ngay) = MONTH(" + "\" " + date + "\"" + ") and year(Ngay)=year(" + "\" " + date + "\"" + ")";
                    cmd = cmd.Replace(@"\", "");
                    DataTable TableHoya3 = new DataTable();
                    TableHoya3 = Sqlexcute.Read_Table_Group(cmd);
                    foreach (DataRow item in TableHoya2.Rows)
                    {
                        TableHoya1.Rows.Add(item.ItemArray);
                    }
                    foreach (DataRow item in TableHoya3.Rows)
                    {
                        TableHoya1.Rows.Add(item.ItemArray);
                    }

                    foreach (DataRow item in TableHoya1.Rows)
                    {
                        DateTime tem = (DateTime)item[1];
                        string tempdate = tem.ToString("yyyy-MM-dd");
                        if (!listdate.Contains(tem))
                        {
                            listdate.Add(tem);
                        }
                        valuedaymonth = new int[listdate.Count];
                    }
                    listdate.Sort();
                    foreach (DataRow item in TableHoya1.Rows)
                    {
                        for (int i = 0; i < listdate.Count; i++)
                        {
                            if ((DateTime)item[1] == listdate[i])
                            {
                                valuedaymonth[i] += (int)item[4];
                                switch ((int)item[5])
                                {
                                    case 1:
                                        ModelMonth[0] += (int)item[4];
                                        break;
                                    case 2:
                                        ModelMonth[1] += (int)item[4];
                                        break;
                                    case 3:
                                        ModelMonth[2] += (int)item[4];
                                        break;
                                    case 4:
                                        ModelMonth[3] += (int)item[4];
                                        break;
                                }
                            }
                        }
                    }
                    DataProductMonth = new ObservableCollection<OrderStatus>();
                    for (int i = 0; i < listdate.Count; i++)
                    {
                        DataProductMonth.Add(new OrderStatus() { Argument = listdate[i].ToString("yyyy-MM-dd"), Value = valuedaymonth[i] });
                        sllastmonth += valuedaymonth[i];
                        QtyThismonth += valuedaymonth[i];
                        slmonth = sllastmonth;
                    }
                    /////processmodelslmonth
                    ProgressModelSLMonth = new ObservableCollection<OrderStatus>();
                    for (int i = 0; i < 4; i++)
                    {
                        ProgressModelSLMonth.Add(new OrderStatus() { Argument = ArgumentModel[i], Value = ModelMonth[i] });

                    }
                    ////////////// sl látmonth
                    listdate = new List<DateTime>();
                    date = today.ToString("yyyy-MM-dd");
                    cmd = "SELECT * FROM DateShift1 WHERE MONTH(Ngay) = MONTH(" + "\" " + date + "\"" + ") and year(Ngay)=year(" + "\" " + date + "\"" + ")";
                    cmd = cmd.Replace(@"\", "");

                    TableHoya1 = Sqlexcute.Read_Table_Group(cmd);
                    cmd = "SELECT * FROM DateShift2 WHERE MONTH(Ngay) = MONTH(" + "\" " + date + "\"" + ") and year(Ngay)=year(" + "\" " + date + "\"" + ")";
                    cmd = cmd.Replace(@"\", "");

                    TableHoya2 = Sqlexcute.Read_Table_Group(cmd);
                    cmd = "SELECT * FROM DateShift3 WHERE MONTH(Ngay) = MONTH(" + "\" " + date + "\"" + ") and year(Ngay)=year(" + "\" " + date + "\"" + ")";
                    cmd = cmd.Replace(@"\", "");

                    TableHoya3 = Sqlexcute.Read_Table_Group(cmd);
                    foreach (DataRow item in TableHoya2.Rows)
                    {
                        TableHoya1.Rows.Add(item.ItemArray);
                    }
                    foreach (DataRow item in TableHoya3.Rows)
                    {
                        TableHoya1.Rows.Add(item.ItemArray);
                    }

                    foreach (DataRow item in TableHoya1.Rows)
                    {
                        DateTime tem = (DateTime)item[1];
                        string tempdate = tem.ToString("yyyy-MM-dd");
                        if (!listdate.Contains(tem))
                        {
                            listdate.Add(tem);
                        }
                        valuedaymonth = new int[listdate.Count];
                    }
                    listdate.Sort();
                    foreach (DataRow item in TableHoya1.Rows)
                    {
                        for (int i = 0; i < listdate.Count; i++)
                        {
                            if ((DateTime)item[1] == listdate[i])
                            {
                                slthismonth += (int)item[4];
                            }
                        }
                    }
                    if (slthismonth > sllastmonth)
                    {
                        ImgTangmonth = @"F:\Cong_Viec\IOT\IotFactory\IotFactory\SourcesImage\Image\trendUp.png";
                    }
                    else if (slthismonth < sllastmonth)
                    {
                        ImgTangmonth = @"F:\Cong_Viec\IOT\IotFactory\IotFactory\SourcesImage\Image\trenDown.png";
                    }
                    else
                    {
                        ImgTangmonth = null;
                    }
                    Loading_Indicator.Finished();
                }
                catch (Exception ex)
                {

                    Loading_Indicator.Finished();
                    MessageBox.Show(ex.Message);
                }
                
            });
            CompareCommand = new RelayCommand<object>((p) => { return true; }, (p) =>
            {
                try
                {
                    Loading_Indicator.BeingBusy();
                    Qtytoday = 0;
                    SLBasket = 0;
                    Model = new int[4];
                    QtyModel1 = QtyModel2 = QtyModel3 = QtyModel4 = 0;
                    int[] WorkedTime = new int[3];
                    int[] valuehourdayCompare = new int[24];
                    int[] valuebaskethourdayCompare = new int[24];
                    int[] value3shift = new int[3];
                    int[] valueBasket3Shift = new int[3];
                    int[] valueModel13Shift = new int[3];
                    int[] valueModel23Shift = new int[3];
                    int[] valueModel33Shift = new int[3];
                    int[] valueModel43Shift = new int[3];
                    string[] ar3shift = new string[] { "SHIFT 1", "SHIFT 2", "SHIFT 3" };
                    string cmd = string.Empty;
                    string date = SelectDatetimes.ToString("yyyy-MM-dd");
                    cmd = "SELECT * FROM DateShift1 where Ngay = '" + date + "' ";
                    DataTable TableHoya1 = new DataTable();
                    TableHoya1 = Sqlexcute.Read_Table_Group(cmd);
                    if (TableHoya1.Rows.Count > 0)
                    {
                        foreach (DataRow item in TableHoya1.Rows)
                        {
                            TimeSpan hour = (TimeSpan)item[2];

                            switch (hour.Hours)
                            {
                                case 8:
                                    valuehourdayCompare[8] += (int)item[4];
                                    value3shift[0] += (int)item[4];
                                    valueBasket3Shift[0]++;
                                    valuebaskethourdayCompare[8]++;
                                    break;
                                case 9:
                                    valuehourdayCompare[9] += (int)item[4];
                                    value3shift[0] += (int)item[4];
                                    valueBasket3Shift[0]++;
                                    valuebaskethourdayCompare[9]++;
                                    break;
                                case 10:
                                    valuehourdayCompare[10] += (int)item[4];
                                    value3shift[0] += (int)item[4];
                                    valueBasket3Shift[0]++;
                                    valuebaskethourdayCompare[10]++;
                                    break;
                                case 11:
                                    valuehourdayCompare[11] += (int)item[4];
                                    value3shift[0] += (int)item[4];
                                    valueBasket3Shift[0]++;
                                    valuebaskethourdayCompare[11]++;
                                    break;
                                case 12:
                                    valuehourdayCompare[12] += (int)item[4];
                                    value3shift[0] += (int)item[4];
                                    valueBasket3Shift[0]++;
                                    valuebaskethourdayCompare[12]++;
                                    break;
                                case 13:
                                    valuehourdayCompare[13] += (int)item[4];
                                    value3shift[0] += (int)item[4];
                                    valueBasket3Shift[0]++;
                                    valuebaskethourdayCompare[13]++;
                                    break;
                                case 14:
                                    valuehourdayCompare[14] += (int)item[4];
                                    value3shift[0] += (int)item[4];
                                    valueBasket3Shift[0]++;
                                    valuebaskethourdayCompare[14]++;
                                    break;
                                case 15:
                                    valuehourdayCompare[15] += (int)item[4];
                                    value3shift[0] += (int)item[4];
                                    valueBasket3Shift[0]++;
                                    valuebaskethourdayCompare[15]++;
                                    break;
                                default:
                                    break;
                            }
                            switch ((int)item[5])
                            {
                                case 1:
                                    valueModel13Shift[0]++;
                                    Model[0]++;

                                    break;
                                case 2:
                                    valueModel23Shift[0]++;
                                    Model[1]++;

                                    break;
                                case 3:
                                    valueModel33Shift[0]++;
                                    Model[2]++;

                                    break;
                                case 4:
                                    valueModel43Shift[0]++;
                                    Model[3]++;

                                    break;
                            }


                        }
                    }
                    cmd = "SELECT * FROM DateShift2 where Ngay = '" + date + "' ";
                    TableHoya1 = Sqlexcute.Read_Table_Group(cmd);
                    if (TableHoya1.Rows.Count > 0)
                    {
                        foreach (DataRow item in TableHoya1.Rows)
                        {
                            TimeSpan hour = (TimeSpan)item[2];
                            switch (hour.Hours)
                            {
                                case 16:
                                    valuehourdayCompare[16] += (int)item[4];
                                    value3shift[1] += (int)item[4];
                                    valueBasket3Shift[1]++;
                                    valuebaskethourdayCompare[16]++;
                                    break;
                                case 17:
                                    valuehourdayCompare[17] += (int)item[4];
                                    value3shift[1] += (int)item[4];
                                    valueBasket3Shift[1]++;
                                    valuebaskethourdayCompare[17]++;
                                    break;
                                case 18:
                                    valuehourdayCompare[18] += (int)item[4];
                                    value3shift[1] += (int)item[4];
                                    valueBasket3Shift[1]++;
                                    valuebaskethourdayCompare[18]++;
                                    break;
                                case 19:
                                    valuehourdayCompare[19] += (int)item[4];
                                    value3shift[1] += (int)item[4];
                                    valueBasket3Shift[1]++;
                                    valuebaskethourdayCompare[19]++;
                                    break;
                                case 20:
                                    valuehourdayCompare[20] += (int)item[4];
                                    value3shift[1] += (int)item[4];
                                    valueBasket3Shift[1]++;
                                    valuebaskethourdayCompare[20]++;
                                    break;
                                case 21:
                                    valuehourdayCompare[21] += (int)item[4];
                                    value3shift[1] += (int)item[4];
                                    valueBasket3Shift[1]++;
                                    valuebaskethourdayCompare[21]++;
                                    break;
                                case 22:
                                    valuehourdayCompare[22] += (int)item[4];
                                    value3shift[1] += (int)item[4];
                                    valueBasket3Shift[1]++;
                                    valuebaskethourdayCompare[22]++;
                                    break;
                                case 23:
                                    valuehourdayCompare[23] += (int)item[4];
                                    value3shift[1] += (int)item[4];
                                    valueBasket3Shift[1]++;
                                    valuebaskethourdayCompare[23]++;
                                    break;
                                default:
                                    break;
                            }
                            switch ((int)item[5])
                            {
                                case 1:
                                    valueModel13Shift[1]++;
                                    Model[0]++;

                                    break;
                                case 2:
                                    valueModel23Shift[1]++;
                                    Model[1]++;

                                    break;
                                case 3:
                                    valueModel33Shift[1]++;
                                    Model[2]++;

                                    break;
                                case 4:
                                    valueModel43Shift[1]++;
                                    Model[3]++;

                                    break;
                            }
                        }
                    }
                    cmd = "SELECT * FROM DateShift3 where Ngay = '" + date + "' ";
                    TableHoya1 = Sqlexcute.Read_Table_Group(cmd);
                    if (TableHoya1.Rows.Count > 0)
                    {
                        foreach (DataRow item in TableHoya1.Rows)
                        {
                            TimeSpan hour = (TimeSpan)item[2];
                            switch (hour.Hours)
                            {
                                case 0:
                                    valuehourdayCompare[0] += (int)item[4];
                                    value3shift[2] += (int)item[4];
                                    valueBasket3Shift[2]++;
                                    valuebaskethourdayCompare[0]++;
                                    break;
                                case 1:
                                    valuehourdayCompare[1] += (int)item[4];
                                    value3shift[2] += (int)item[4];
                                    valueBasket3Shift[2]++;
                                    valuebaskethourdayCompare[1]++;
                                    break;
                                case 2:
                                    valuehourdayCompare[2] += (int)item[4];
                                    value3shift[2] += (int)item[4];
                                    valueBasket3Shift[2]++;
                                    valuebaskethourdayCompare[2]++;
                                    break;
                                case 3:
                                    valuehourdayCompare[3] += (int)item[4];
                                    value3shift[2] += (int)item[4];
                                    valueBasket3Shift[2]++;
                                    valuebaskethourdayCompare[3]++;
                                    break;
                                case 4:
                                    valuehourdayCompare[4] += (int)item[4];
                                    value3shift[2] += (int)item[4];
                                    valueBasket3Shift[2]++;
                                    valuebaskethourdayCompare[4]++;
                                    break;
                                case 5:
                                    valuehourdayCompare[5] += (int)item[4];
                                    value3shift[2] += (int)item[4];
                                    valueBasket3Shift[2]++;
                                    valuebaskethourdayCompare[5]++;
                                    break;
                                case 6:
                                    valuehourdayCompare[6] += (int)item[4];
                                    value3shift[2] += (int)item[4];
                                    valueBasket3Shift[2]++;
                                    valuebaskethourdayCompare[6]++;
                                    break;
                                case 7:
                                    valuehourdayCompare[7] += (int)item[4];
                                    value3shift[2] += (int)item[4];
                                    valueBasket3Shift[2]++;
                                    valuebaskethourdayCompare[7]++;
                                    break;
                                default:
                                    break;
                            }

                            switch ((int)item[5])
                            {
                                case 1:
                                    valueModel13Shift[2]++;
                                    Model[0]++;

                                    break;
                                case 2:
                                    valueModel23Shift[2]++;
                                    Model[1]++;
                                    break;
                                case 3:
                                    valueModel33Shift[2]++;
                                    Model[2]++;

                                    break;
                                case 4:
                                    valueModel43Shift[2]++;
                                    Model[3]++;

                                    break;

                            }
                        }
                    }

                    SeriesHours = new ObservableCollection<DataSeries>()
                {
                              new DataSeries
                              {
                                     Name = "SHIFT 1",
                                     Values = new ObservableCollection<Comparepoint>()
                                     {

                                          new Comparepoint("Fist hours", valuehourdayCompare[8]),
                                          new Comparepoint("Second hours", valuehourdayCompare[9]),
                                          new Comparepoint("Third hours", valuehourdayCompare[10]),
                                          new Comparepoint("Fourth hours", valuehourdayCompare[11]),
                                          new Comparepoint("Fifth hours", valuehourdayCompare[12]),
                                          new Comparepoint("Sixth hours", valuehourdayCompare[13]),
                                          new Comparepoint("Seventh hours", valuehourdayCompare[14]),
                                          new Comparepoint("Eigh hours", valuehourdayCompare[15]),
                                     }
                              },
                              new DataSeries
                              {
                                      Name = "SHIFT 2",
                                      Values = new ObservableCollection<Comparepoint>()
                                      {
                                          new Comparepoint("Fist hours", valuehourdayCompare[16]),
                                          new Comparepoint("Second hours", valuehourdayCompare[17]),
                                          new Comparepoint("Third hours", valuehourdayCompare[18]),
                                          new Comparepoint("Fourth hours", valuehourdayCompare[19]),
                                          new Comparepoint("Fifth hours", valuehourdayCompare[20]),
                                          new Comparepoint("Sixth hours", valuehourdayCompare[21]),
                                          new Comparepoint("Seventh hours", valuehourdayCompare[22]),
                                          new Comparepoint("Eigh hours", valuehourdayCompare[23]),
                                      }
                              },
                              new DataSeries
                              {
                                     Name = "SHIFT 3",
                                     Values = new ObservableCollection<Comparepoint>()
                                     {
                                          new Comparepoint("Fist hours", valuehourdayCompare[0]),
                                          new Comparepoint("Second hours", valuehourdayCompare[1]),
                                          new Comparepoint("Third hours", valuehourdayCompare[2]),
                                          new Comparepoint("Fourth hours", valuehourdayCompare[3]),
                                          new Comparepoint("Fifth hours", valuehourdayCompare[4]),
                                          new Comparepoint("Sixth hours", valuehourdayCompare[5]),
                                          new Comparepoint("Seventh hours", valuehourdayCompare[6]),
                                          new Comparepoint("Eigh hours", valuehourdayCompare[7]),
                                     }
                              },
               };
                    SeriesHoursBasket = new ObservableCollection<DataSeries>()
                {
                              new DataSeries
                              {
                                     Name = "SHIFT 1",
                                     Values = new ObservableCollection<Comparepoint>()
                                     {

                                          new Comparepoint("Fist hours", valuebaskethourdayCompare[8]),
                                          new Comparepoint("Second hours", valuebaskethourdayCompare[9]),
                                          new Comparepoint("Third hours", valuebaskethourdayCompare[10]),
                                          new Comparepoint("Fourth hours", valuebaskethourdayCompare[11]),
                                          new Comparepoint("Fifth hours", valuebaskethourdayCompare[12]),
                                          new Comparepoint("Sixth hours", valuebaskethourdayCompare[13]),
                                          new Comparepoint("Seventh hours", valuebaskethourdayCompare[14]),
                                          new Comparepoint("Eigh hours", valuebaskethourdayCompare[15]),
                                     }
                              },
                              new DataSeries
                              {
                                      Name = "SHIFT 2",
                                      Values = new ObservableCollection<Comparepoint>()
                                      {
                                          new Comparepoint("Fist hours", valuebaskethourdayCompare[16]),
                                          new Comparepoint("Second hours", valuebaskethourdayCompare[17]),
                                          new Comparepoint("Third hours", valuebaskethourdayCompare[18]),
                                          new Comparepoint("Fourth hours", valuebaskethourdayCompare[19]),
                                          new Comparepoint("Fifth hours", valuebaskethourdayCompare[20]),
                                          new Comparepoint("Sixth hours", valuebaskethourdayCompare[21]),
                                          new Comparepoint("Seventh hours", valuebaskethourdayCompare[22]),
                                          new Comparepoint("Eigh hours", valuebaskethourdayCompare[23]),
                                      }
                              },
                              new DataSeries
                              {
                                     Name = "SHIFT 3",
                                     Values = new ObservableCollection<Comparepoint>()
                                     {
                                          new Comparepoint("Fist hours", valuebaskethourdayCompare[0]),
                                          new Comparepoint("Second hours", valuebaskethourdayCompare[1]),
                                          new Comparepoint("Third hours", valuebaskethourdayCompare[2]),
                                          new Comparepoint("Fourth hours",valuebaskethourdayCompare[3]),
                                          new Comparepoint("Fifth hours", valuebaskethourdayCompare[4]),
                                          new Comparepoint("Sixth hours", valuebaskethourdayCompare[5]),
                                          new Comparepoint("Seventh hours", valuebaskethourdayCompare[6]),
                                          new Comparepoint("Eigh hours", valuebaskethourdayCompare[7]),
                                     }
                              },
               };
                    ProgressSLShift = new ObservableCollection<OrderStatus>();
                    for (int i = 0; i < 3; i++)
                    {
                        ProgressSLShift.Add(new OrderStatus() { Argument = ar3shift[i], Value = value3shift[i] });
                        Qtytoday += value3shift[i];
                    }
                    ProgressBasketShift = new ObservableCollection<OrderStatus>();
                    for (int i = 0; i < 3; i++)
                    {
                        ProgressBasketShift.Add(new OrderStatus() { Argument = ar3shift[i], Value = valueBasket3Shift[i] });
                        SLBasket += valueBasket3Shift[i];
                    }
                    ProgressModel1Shift = new ObservableCollection<OrderStatus>();
                    for (int i = 0; i < 3; i++)
                    {
                        ProgressModel1Shift.Add(new OrderStatus() { Argument = ar3shift[i], Value = valueModel13Shift[i] });
                        QtyModel1 += valueModel13Shift[i];
                    }
                    ProgressModel2Shift = new ObservableCollection<OrderStatus>();
                    for (int i = 0; i < 3; i++)
                    {
                        ProgressModel2Shift.Add(new OrderStatus() { Argument = ar3shift[i], Value = valueModel23Shift[i] });
                        QtyModel2 += valueModel23Shift[i];
                    }
                    ProgressModel3Shift = new ObservableCollection<OrderStatus>();
                    for (int i = 0; i < 3; i++)
                    {
                        ProgressModel3Shift.Add(new OrderStatus() { Argument = ar3shift[i], Value = valueModel33Shift[i] });
                        QtyModel3 += valueModel33Shift[i];
                    }
                    ProgressModel4Shift = new ObservableCollection<OrderStatus>();
                    for (int i = 0; i < 3; i++)
                    {
                        ProgressModel4Shift.Add(new OrderStatus() { Argument = ar3shift[i], Value = valueModel43Shift[i] });
                        QtyModel4 += valueModel43Shift[i];
                    }

                    ProgressShiftModel = new ObservableCollection<OrderStatus>();
                    for (int i = 0; i < 4; i++)
                    {
                        ProgressShiftModel.Add(new OrderStatus() { Argument = ArgumentModel[i], Value = Model[i] });
                    }
                    for (int i = 8; i < 16; i++)
                    {
                        if (valuehourdayCompare[i] > 0)
                        {
                            WorkedTime[0]++;
                        }
                    }
                    for (int i = 16; i < 24; i++)
                    {
                        if (valuehourdayCompare[i] > 0)
                        {
                            WorkedTime[1]++;
                        }
                    }
                    for (int i = 0; i < 8; i++)
                    {
                        if (valuehourdayCompare[i] > 0)
                        {
                            WorkedTime[2]++;
                        }
                    }
                    WoringTime = new ObservableCollection<OrderStatus>();

                    for (int i = 0; i < 3; i++)
                    {
                        WoringTime.Add(new OrderStatus() { Argument = ar3shift[i], Value = WorkedTime[i] });
                    }
                    Loading_Indicator.Finished();
                }
                catch (Exception ex)
                {

                    Loading_Indicator.Finished();
                    MessageBox.Show(ex.Message);
                }
                
            });
            Detail = new RelayCommand<object>((p) => { return true; }, (p) =>
            {
                try
                {
                    ModelView modelView = new ModelView();
                    modelView.Left = 320;
                    modelView.Top = 380;
                    modelView.ShowDialog();
                }
                catch (Exception ex)
                {
                    ModelView modelView = new ModelView();
                    modelView.Close();
                    MessageBox.Show(ex.Message);
                }
               
            });
            ClickSS = new RelayCommand<object>((p) => { return true; }, (p) =>
            {
                try
                {
                    Loading_Indicator.BeingBusy();
                    DateTime today = DateTime.Today;
                    string cmd = string.Empty;
                    string date = today.ToString("yyyy-MM-dd");
                    if (IndexShift == 0)
                    {
                        cmd = "SELECT * FROM DateShift1 where Ngay = '" + date + "' ";
                        DataTable TableHoya1 = new DataTable();
                        TableHoya1 = Sqlexcute.Read_Table_Group(cmd);
                        QuantityShiftToday = QuantityShiftYesterday = BasketShiftToday = BasketShiftYesterday = 0;
                        if (TableHoya1.Rows.Count > 0)
                        {
                            foreach (DataRow item in TableHoya1.Rows)
                            {
                                QuantityShiftToday += (int)item[4];
                                BasketShiftToday++;
                            }
                        }
                        ////// SL Homqua
                        date = today.AddDays(-1).ToString("yyyy-MM-dd");
                        cmd = "SELECT * FROM DateShift1 where Ngay = '" + date + "' ";
                        TableHoya1 = Sqlexcute.Read_Table_Group(cmd);
                        if (TableHoya1.Rows.Count > 0)
                        {
                            foreach (DataRow item in TableHoya1.Rows)
                            {
                                QuantityShiftYesterday += (int)item[4];
                                BasketShiftYesterday++;
                            }
                        }
                    }
                    else if (IndexShift == 1)
                    {
                        cmd = "SELECT * FROM DateShift2 where Ngay = '" + date + "' ";
                        DataTable TableHoya1 = new DataTable();
                        TableHoya1 = Sqlexcute.Read_Table_Group(cmd);
                        QuantityShiftToday = QuantityShiftYesterday = BasketShiftToday = BasketShiftYesterday = 0;
                        if (TableHoya1.Rows.Count > 0)
                        {
                            foreach (DataRow item in TableHoya1.Rows)
                            {
                                QuantityShiftToday += (int)item[4];
                                BasketShiftToday++;
                            }
                        }
                        ////// SL Homqua
                        date = today.AddDays(-1).ToString("yyyy-MM-dd");
                        cmd = "SELECT * FROM DateShift2 where Ngay = '" + date + "' ";
                        TableHoya1 = Sqlexcute.Read_Table_Group(cmd);
                        if (TableHoya1.Rows.Count > 0)
                        {
                            foreach (DataRow item in TableHoya1.Rows)
                            {
                                QuantityShiftYesterday += (int)item[4];
                                BasketShiftYesterday++;
                            }
                        }
                    }
                    else if (IndexShift == 2)
                    {
                        cmd = "SELECT * FROM DateShift3 where Ngay = '" + date + "' ";
                        DataTable TableHoya1 = new DataTable();
                        TableHoya1 = Sqlexcute.Read_Table_Group(cmd);
                        QuantityShiftToday = QuantityShiftYesterday = BasketShiftToday = BasketShiftYesterday = 0;
                        if (TableHoya1.Rows.Count > 0)
                        {
                            foreach (DataRow item in TableHoya1.Rows)
                            {
                                QuantityShiftToday += (int)item[4];
                                BasketShiftToday++;
                            }
                        }
                        ////// SL Homqua
                        date = today.AddDays(-1).ToString("yyyy-MM-dd");
                        cmd = "SELECT * FROM DateShift3 where Ngay = '" + date + "' ";
                        TableHoya1 = Sqlexcute.Read_Table_Group(cmd);
                        if (TableHoya1.Rows.Count > 0)
                        {
                            foreach (DataRow item in TableHoya1.Rows)
                            {
                                QuantityShiftYesterday += (int)item[4];
                                BasketShiftYesterday++;
                            }
                        }
                    }
                    if (QuantityShiftToday > QuantityShiftYesterday)
                    {
                        string Systemconfigmagetangday = System.IO.Directory.GetCurrentDirectory() + @"\" + @"image\trendUp.png";

                        ImgTang = Systemconfigmagetangday;

                    }
                    else if (QuantityShiftToday < QuantityShiftYesterday)
                    {
                        string Systemconfigmagetangday = System.IO.Directory.GetCurrentDirectory() + @"\" + @"image\trenDown.png";

                        ImgTang = Systemconfigmagetangday;

                    }
                    else
                    {
                        ImgTang = null;
                    }
                    if (BasketShiftToday > BasketShiftYesterday)
                    {
                        string Systemconfigmagetangday = System.IO.Directory.GetCurrentDirectory() + @"\" + @"image\trendUp.png";

                        ImgTang1 = Systemconfigmagetangday;

                    }
                    else if (BasketShiftToday < BasketShiftYesterday)
                    {
                        string Systemconfigmagetangday = System.IO.Directory.GetCurrentDirectory() + @"\" + @"image\trenDown.png";

                        ImgTang1 = Systemconfigmagetangday;

                    }
                    else
                    {
                        ImgTang1 = null;
                    }
                    Loading_Indicator.Finished();
                }
                catch (Exception ex)
                {
                    Loading_Indicator.Finished();
                    MessageBox.Show(ex.Message);
                   
                }
               
            });
            ThisYear = new RelayCommand<object>((p) => { return true; }, (p) =>
            {
                try
                {
                    Loading_Indicator.BeingBusy();
                    slthisyear = sllastyear = 0;
                    int[] Thisyear = new int[4];
                    int[] Lastyear = new int[4];
                    int[] valueMonth = new int[12];
                    string[] arMonth = new string[12] { "January", "February", "March", "April", "May", "June", "July", "August", "September", "October", "November", "December" };
                    DateTime today = DateTime.Today;
                    year = today.ToString("yyyy");
                    List<string> listdate = new List<string>();

                    string cmd = string.Empty;
                    string date = today.ToString("yyyy-MM-dd");
                    cmd = "SELECT * FROM DateShift1 WHERE year(Ngay) = year(" + "\" " + date + "\"" + ")";
                    cmd = cmd.Replace(@"\", "");
                    DataTable TableHoya1 = new DataTable();
                    TableHoya1 = Sqlexcute.Read_Table_Group(cmd);
                    cmd = "SELECT * FROM DateShift2 WHERE year(Ngay) = year(" + "\" " + date + "\"" + ")";
                    cmd = cmd.Replace(@"\", "");
                    DataTable TableHoya2 = new DataTable();
                    TableHoya2 = Sqlexcute.Read_Table_Group(cmd);
                    cmd = "SELECT * FROM DateShift3 WHERE year(Ngay) = year(" + "\" " + date + "\"" + ")";
                    cmd = cmd.Replace(@"\", "");
                    DataTable TableHoya3 = new DataTable();
                    TableHoya3 = Sqlexcute.Read_Table_Group(cmd);

                    foreach (DataRow item in TableHoya2.Rows)
                    {
                        TableHoya1.Rows.Add(item.ItemArray);
                    }
                    foreach (DataRow item in TableHoya3.Rows)
                    {
                        TableHoya1.Rows.Add(item.ItemArray);
                    }

                    foreach (DataRow item in TableHoya1.Rows)
                    {
                        DateTime month = (DateTime)item[1];
                        switch (month.Month)
                        {
                            case 1:
                                valueMonth[0] += (int)item[4];

                                break;
                            case 2:
                                valueMonth[1] += (int)item[4];
                                break;
                            case 3:
                                valueMonth[2] += (int)item[4];
                                break;
                            case 4:
                                valueMonth[3] += (int)item[4];
                                break;
                            case 5:
                                valueMonth[4] += (int)item[4];
                                break;
                            case 6:
                                valueMonth[5] += (int)item[4];
                                break;
                            case 7:
                                valueMonth[6] += (int)item[4];
                                break;
                            case 8:
                                valueMonth[7] += (int)item[4];
                                break;
                            case 9:
                                valueMonth[8] += (int)item[4];
                                break;
                            case 10:
                                valueMonth[9] += (int)item[4];
                                break;
                            case 11:
                                valueMonth[10] += (int)item[4];
                                break;
                            case 12:
                                valueMonth[11] += (int)item[4];
                                break;

                        }
                        switch ((int)item[5])
                        {
                            case 1:
                                Thisyear[0] += (int)item[4];
                                break;
                            case 2:
                                Thisyear[1] += (int)item[4];
                                break;
                            case 3:
                                Thisyear[2] += (int)item[4];
                                break;
                            case 4:
                                Thisyear[3] += (int)item[4];
                                break;
                        }
                    }

                    DataProductYear = new ObservableCollection<OrderStatus>();
                    for (int i = 0; i < 12; i++)
                    {
                        DataProductYear.Add(new OrderStatus() { Argument = arMonth[i], Value = valueMonth[i] });
                        slthisyear += valueMonth[i];
                        slyear = slthisyear;

                    }

                    ////sl lastyear
                    date = today.AddYears(-1).ToString("yyyy-MM-dd");
                    cmd = "SELECT * FROM DateShift1 WHERE year(Ngay) = year(" + "\" " + date + "\"" + ")";
                    cmd = cmd.Replace(@"\", "");

                    TableHoya1 = Sqlexcute.Read_Table_Group(cmd);
                    cmd = "SELECT * FROM DateShift2 WHERE year(Ngay) = year(" + "\" " + date + "\"" + ")";
                    cmd = cmd.Replace(@"\", "");

                    TableHoya2 = Sqlexcute.Read_Table_Group(cmd);
                    cmd = "SELECT * FROM DateShift3 WHERE year(Ngay) = year(" + "\" " + date + "\"" + ")";
                    cmd = cmd.Replace(@"\", "");

                    TableHoya3 = Sqlexcute.Read_Table_Group(cmd);

                    foreach (DataRow item in TableHoya2.Rows)
                    {
                        TableHoya1.Rows.Add(item.ItemArray);
                    }
                    foreach (DataRow item in TableHoya3.Rows)
                    {
                        TableHoya1.Rows.Add(item.ItemArray);
                    }

                    foreach (DataRow item in TableHoya1.Rows)
                    {

                        sllastyear += (int)item[4];
                        switch ((int)item[5])
                        {
                            case 1:
                                Lastyear[0] += (int)item[4];
                                break;
                            case 2:
                                Lastyear[1] += (int)item[4];
                                break;
                            case 3:
                                Lastyear[2] += (int)item[4];
                                break;
                            case 4:
                                Lastyear[3] += (int)item[4];
                                break;
                        }
                    }

                    if (slthisyear > sllastyear)
                    {
                        string Systemconfigmagetangday = System.IO.Directory.GetCurrentDirectory() + @"\" + @"image\trendUp.png";

                        ImgTangmonth = Systemconfigmagetangday;

                    }
                    else if (slthisyear < sllastyear)
                    {
                        string Systemconfigmagetangday = System.IO.Directory.GetCurrentDirectory() + @"\" + @"image\trenDown.png";

                        ImgTangmonth = Systemconfigmagetangday;
                    }
                    else
                    {
                        ImgTangyear = null;
                    }

                    Seriesyear = new ObservableCollection<DataSeries>()
                {
                     new DataSeries
                              {
                                      Name = (SelectDatetimes.Year-1).ToString(),
                                      Values = new ObservableCollection<Comparepoint>()
                                      {
                                          new Comparepoint("Total", Lastyear[0]+Lastyear[1]+Lastyear[2]+Lastyear[3]),
                                          new Comparepoint("Model 1", Lastyear[0]),
                                          new Comparepoint("Model 2", Lastyear[1]),
                                          new Comparepoint("Model 3", Lastyear[2]),
                                          new Comparepoint("Model 4", Lastyear[3]),
                                      }
                              },
                              new DataSeries
                              {
                                     Name = SelectDatetimes.Year.ToString(),
                                     Values = new ObservableCollection<Comparepoint>()
                                     {

                                          new Comparepoint("Total", Thisyear[0]+Thisyear[1]+Thisyear[2]+Thisyear[3]),
                                          new Comparepoint("Model 1", Thisyear[0]),
                                          new Comparepoint("Model 2", Thisyear[1]),
                                          new Comparepoint("Model 3", Thisyear[2]),
                                          new Comparepoint("Model 4", Thisyear[3]),

                                     }
                              },


               };
                    Loading_Indicator.Finished();
                }
                catch (Exception ex)
                {
                    Loading_Indicator.Finished();
                    
                    MessageBox.Show(ex.Message);
                    
                }
                
            });
            LastYear = new RelayCommand<object>((p) => { return true; }, (p) =>
            {
                try
                {
                    Loading_Indicator.BeingBusy();
                    sllastyear = slthisyear = 0;
                    int[] valueMonth = new int[12];
                    string[] arMonth = new string[12] { "January", "February", "March", "April", "May", "June", "July", "August", "September", "October", "November", "December" };
                    DateTime today = DateTime.Today;
                    year = today.AddYears(-1).ToString("yyyy");
                    List<string> listdate = new List<string>();

                    string cmd = string.Empty;
                    string date = today.AddYears(-1).ToString("yyyy-MM-dd");
                    cmd = "SELECT * FROM DateShift1 WHERE year(Ngay) = year(" + "\" " + date + "\"" + ")";
                    cmd = cmd.Replace(@"\", "");
                    DataTable TableHoya1 = new DataTable();
                    TableHoya1 = Sqlexcute.Read_Table_Group(cmd);
                    cmd = "SELECT * FROM DateShift2 WHERE year(Ngay) = year(" + "\" " + date + "\"" + ")";
                    cmd = cmd.Replace(@"\", "");
                    DataTable TableHoya2 = new DataTable();
                    TableHoya2 = Sqlexcute.Read_Table_Group(cmd);
                    cmd = "SELECT * FROM DateShift3 WHERE year(Ngay) = year(" + "\" " + date + "\"" + ")";
                    cmd = cmd.Replace(@"\", "");
                    DataTable TableHoya3 = new DataTable();
                    TableHoya3 = Sqlexcute.Read_Table_Group(cmd);

                    foreach (DataRow item in TableHoya2.Rows)
                    {
                        TableHoya1.Rows.Add(item.ItemArray);
                    }
                    foreach (DataRow item in TableHoya3.Rows)
                    {
                        TableHoya1.Rows.Add(item.ItemArray);
                    }

                    foreach (DataRow item in TableHoya1.Rows)
                    {
                        DateTime month = (DateTime)item[1];
                        switch (month.Month)
                        {
                            case 1:
                                valueMonth[0] += (int)item[4];

                                break;
                            case 2:
                                valueMonth[1] += (int)item[4];
                                break;
                            case 3:
                                valueMonth[2] += (int)item[4];
                                break;
                            case 4:
                                valueMonth[3] += (int)item[4];
                                break;
                            case 5:
                                valueMonth[4] += (int)item[4];
                                break;
                            case 6:
                                valueMonth[5] += (int)item[4];
                                break;
                            case 7:
                                valueMonth[6] += (int)item[4];
                                break;
                            case 8:
                                valueMonth[7] += (int)item[4];
                                break;
                            case 9:
                                valueMonth[8] += (int)item[4];
                                break;
                            case 10:
                                valueMonth[9] += (int)item[4];
                                break;
                            case 11:
                                valueMonth[10] += (int)item[4];
                                break;
                            case 12:
                                valueMonth[11] += (int)item[4];
                                break;

                        }
                    }

                    DataProductYear = new ObservableCollection<OrderStatus>();
                    for (int i = 0; i < 12; i++)
                    {
                        DataProductYear.Add(new OrderStatus() { Argument = arMonth[i], Value = valueMonth[i] });
                        sllastyear += valueMonth[i];
                        slyear = sllastyear;
                    }
                    ////sl lastyear
                    date = today.ToString("yyyy-MM-dd");
                    cmd = "SELECT * FROM DateShift1 WHERE year(Ngay) = year(" + "\" " + date + "\"" + ")";
                    cmd = cmd.Replace(@"\", "");

                    TableHoya1 = Sqlexcute.Read_Table_Group(cmd);
                    cmd = "SELECT * FROM DateShift2 WHERE year(Ngay) = year(" + "\" " + date + "\"" + ")";
                    cmd = cmd.Replace(@"\", "");

                    TableHoya2 = Sqlexcute.Read_Table_Group(cmd);
                    cmd = "SELECT * FROM DateShift3 WHERE year(Ngay) = year(" + "\" " + date + "\"" + ")";
                    cmd = cmd.Replace(@"\", "");

                    TableHoya3 = Sqlexcute.Read_Table_Group(cmd);

                    foreach (DataRow item in TableHoya2.Rows)
                    {
                        TableHoya1.Rows.Add(item.ItemArray);
                    }
                    foreach (DataRow item in TableHoya3.Rows)
                    {
                        TableHoya1.Rows.Add(item.ItemArray);
                    }

                    foreach (DataRow item in TableHoya1.Rows)
                    {
                        DateTime month = (DateTime)item[1];
                        slthisyear += (int)item[4];
                    }
                    if (slthisyear > sllastyear)
                    {
                        ImgTangyear = @"F:\Cong_Viec\IOT\IotFactory\IotFactory\SourcesImage\Image\trendUp.png";
                    }
                    else if (slthisyear < sllastyear)
                    {
                        ImgTangyear = @"F:\Cong_Viec\IOT\IotFactory\IotFactory\SourcesImage\Image\trenDown.png";
                    }
                    else
                    {
                        ImgTangyear = null;
                    }
                    Loading_Indicator.Finished();
                }
                catch (Exception ex)
                {
                    Loading_Indicator.Finished();
                    MessageBox.Show(ex.Message);
                }
              
            });
            ONLINE = new RelayCommand<object>((p) => { return true; }, (p) =>
            {
                try
                {
                    timerLoad.IsEnabled = true;
                    IsenabledCompare = IsenabledDate = IsenabledProduct = IsenabledShift = false;
                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message);
                }
                
            });
            OFFLINE = new RelayCommand<object>((p) => { return true; }, (p) =>
            {
                try
                {
                    timerLoad.IsEnabled = false;
                    if ((int)p == 0 && CheckOffline)
                    {
                        IsenabledDate = true;
                        IsenabledProduct = false;
                        IsenabledCompare = false;
                        IsenabledShift = false;
                    }
                    else if ((int)p == 1 && CheckOffline)
                    {
                        IsenabledDate = false;
                        IsenabledProduct = true;
                        IsenabledCompare = false;
                        IsenabledShift = false;
                    }
                    else if ((int)p == 2 && CheckOffline)
                    {
                        IsenabledDate = false;
                        IsenabledProduct = false;
                        IsenabledCompare = false;
                        IsenabledShift = true;
                    }
                    else if ((int)p == 3 && CheckOffline)
                    {
                        IsenabledDate = false;
                        IsenabledProduct = false;
                        IsenabledCompare = true;
                        IsenabledShift = false;
                    }
                    else if ((int)p == 4 && CheckOffline)
                    {

                    }
                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message);
                }
               
            });
        }

        private void TimeWrite_Tick(object sender, EventArgs e)
        {
            try
            {
                DateTime timenow = DateTime.Now;
                int houra = timenow.Hour;
                string Gio = timenow.ToString("HH:mm:ss");
                string Ngay = timenow.ToString("yyyy-MM-dd");
                string QR = "1";
                model++;
                if (model > 4)
                {
                    model = 1;
                }

                if (houra >= 8 && houra < 16)
                {

                    _ = Sqlexcute.SQL_command("INSERT INTO `Dateshift1`(`Ngay`, `Gio`, `QR_RACK`, `SoLuongKinh`, `Model`) VALUES ('" + Ngay + "','" + Gio + "' , '" + QR + "', '" + 20 + "','" + model + "')", MySQLDaTaHoya.Database);

                }
                if (houra >= 16 && houra < 24)
                {
                    _ = Sqlexcute.SQL_command("INSERT INTO `Dateshift2`(`Ngay`, `Gio`, `QR_RACK`, `SoLuongKinh`, `Model`) VALUES ('" + Ngay + "','" + Gio + "' , '" + QR + "', '" + 20 + "','" + model + "')", MySQLDaTaHoya.Database);

                }
                if (houra >= 0 && houra < 8)
                {
                    _ = Sqlexcute.SQL_command("INSERT INTO `Dateshift3`(`Ngay`, `Gio`, `QR_RACK`, `SoLuongKinh`, `Model`) VALUES ('" + Ngay + "','" + Gio + "' , '" + QR + "', '" + 20 + "','" + model + "')", MySQLDaTaHoya.Database);

                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }


        }

        private void DongHO_Tick(object sender, EventArgs e)
        {
            //PerformanceCounter myAppCpu = new PerformanceCounter();
            //PerformanceCounter TotalCpu = new PerformanceCounter();
            //string prcName = Process.GetCurrentProcess().ProcessName;
            //var counter_Exec = new PerformanceCounter("Process", "Working Set - Private", prcName);
            //myAppCpu.CategoryName = "Process";
            //myAppCpu.CounterName = "% Processor Time";
            //myAppCpu.InstanceName = "Hoya";
            //TotalCpu.CategoryName = "Processor";
            //TotalCpu.CounterName = "% Processor Time";
            //TotalCpu.InstanceName = "_Total";
            //valueCPU = (double)myAppCpu.NextValue()/(double)(TotalCpu.NextValue());
            //valueCPU= Math.Round(valueCPU, 1);
            //valueRam = (double)counter_Exec.RawValue / 1024000.0;

            timetoday = DateTime.Now;
        }

        private void TimerLoad_Tick(object sender, EventArgs u)
        {
            try
            {
                DateTime TimeNow = DateTime.Now;
                int hourshift = TimeNow.Hour;
                if (hourshift >= 0 && hourshift < 8)
                {
                    IndexShift = 2;
                }
                else if (hourshift >= 8 && hourshift < 16)
                {
                    IndexShift = 0;
                }
                else if (hourshift >= 16 && hourshift < 24)
                {
                    IndexShift = 1;
                }
                int[] TotalBasket = new int[2];
                int[] _SLModel = new int[4];
                string[] SSTongShift = new string[] { "Total", "Total Shift" };
                double[] TotalBasketPhantram = new double[2];
                double[] _SLModelPhantram = new double[8];

                int[] valuedayShit = new int[8];
                int[] WordTime = new int[2];
                int[] SSTotalShift = new int[2];
                string[] TimeLV = new string[] { "OEE", "NOEE" };

                string cmd = string.Empty;
                string date = DateTime.Today.ToString("yyyy-MM-dd");
                SLModel[0] = SLModel[1] = SLModel[2] = SLModel[3] = 0;
                listShift.Clear();
                if (IndexShift == 0)
                {

                    Shift = "Shift 1";
                    cmd = "SELECT * FROM DateShift1 where Ngay = '" + date + "' ";
                    DataTable TableHoya1 = new DataTable();
                    TableHoya1 = Sqlexcute.Read_Table_Group(cmd);
                    if (TableHoya1.Rows.Count > 0)
                    {
                        foreach (DataRow item in TableHoya1.Rows)
                        {
                            listShift.Add(new classlistshift() { Hour = (TimeSpan)item[2], Basket = (string)item[3], Model = (int)item[5], Quantity = (int)item[4] });
                            switch ((int)item[5])
                            {
                                case 1:
                                    TotalBasket[0]++;
                                    TotalBasket[1]++;
                                    _SLModel[0] += (int)item[4];
                                    SLModel[0] += (int)item[4];
                                    break;
                                case 2:
                                    TotalBasket[0]++;
                                    TotalBasket[1]++;

                                    _SLModel[1] += (int)item[4];
                                    SLModel[1] += (int)item[4];
                                    break;
                                case 3:
                                    TotalBasket[0]++;
                                    TotalBasket[1]++;
                                    _SLModel[2] += (int)item[4];
                                    SLModel[2] += (int)item[4];
                                    break;
                                case 4:

                                    TotalBasket[0]++;
                                    TotalBasket[1]++;

                                    _SLModel[3] += (int)item[4];
                                    SLModel[3] += (int)item[4];
                                    break;
                            }

                            TimeSpan hour = (TimeSpan)item[2];
                            switch (hour.Hours)
                            {
                                case 8:
                                    valuedayShit[0] += (int)item[4];
                                    break;
                                case 9:
                                    valuedayShit[1] += (int)item[4];
                                    break;
                                case 10:
                                    valuedayShit[2] += (int)item[4];
                                    break;
                                case 11:
                                    valuedayShit[3] += (int)item[4];
                                    break;
                                case 12:
                                    valuedayShit[4] += (int)item[4];
                                    break;
                                case 13:
                                    valuedayShit[5] += (int)item[4];
                                    break;
                                case 14:
                                    valuedayShit[6] += (int)item[4];
                                    break;
                                case 15:
                                    valuedayShit[7] += (int)item[4];
                                    break;
                            }
                        }
                    }
                    cmd = "SELECT * FROM DateShift2 where Ngay = '" + date + "' ";
                    TableHoya1 = Sqlexcute.Read_Table_Group(cmd);
                    if (TableHoya1.Rows.Count > 0)
                    {
                        foreach (DataRow item in TableHoya1.Rows)
                        {
                            switch ((int)item[5])
                            {
                                case 1:
                                    TotalBasket[0]++;
                                    _SLModel[0] += (int)item[4];
                                    break;
                                case 2:
                                    TotalBasket[0]++;
                                    _SLModel[1] += (int)item[4];
                                    break;
                                case 3:
                                    TotalBasket[0]++;
                                    _SLModel[2] += (int)item[4];
                                    break;
                                case 4:
                                    TotalBasket[0]++;
                                    _SLModel[3] += (int)item[4];
                                    break;
                            }
                        }
                    }
                    cmd = "SELECT * FROM DateShift3 where Ngay = '" + date + "' ";
                    TableHoya1 = Sqlexcute.Read_Table_Group(cmd);
                    if (TableHoya1.Rows.Count > 0)
                    {
                        foreach (DataRow item in TableHoya1.Rows)
                        {
                            switch ((int)item[5])
                            {
                                case 1:
                                    TotalBasket[0]++;
                                    _SLModel[0] += (int)item[4];
                                    break;
                                case 2:
                                    TotalBasket[0]++;
                                    _SLModel[1] += (int)item[4];
                                    break;
                                case 3:
                                    TotalBasket[0]++;
                                    _SLModel[2] += (int)item[4];
                                    break;
                                case 4:
                                    TotalBasket[0]++;
                                    _SLModel[3] += (int)item[4];
                                    break;
                            }
                        }
                    }
                    TotalBasketPhantram[1] = (double)TotalBasket[1] / (double)TotalBasket[0];
                    TotalBasketPhantram[0] = 1 - TotalBasketPhantram[1];
                    _SLModelPhantram[1] = (double)SLModel[0] / (double)_SLModel[0];
                    _SLModelPhantram[0] = 1 - _SLModelPhantram[1];
                    _SLModelPhantram[3] = (double)SLModel[1] / (double)_SLModel[1];
                    _SLModelPhantram[2] = 1 - _SLModelPhantram[3];
                    _SLModelPhantram[5] = (double)SLModel[2] / (double)_SLModel[2];
                    _SLModelPhantram[4] = 1 - _SLModelPhantram[5];
                    _SLModelPhantram[7] = (double)SLModel[3] / (double)_SLModel[3];
                    _SLModelPhantram[6] = 1 - _SLModelPhantram[7];
                    a = TotalBasket[1];
                    b = TotalBasket[0];
                    c = SLModel[0];
                    d = _SLModel[0];
                    e = SLModel[1];
                    f = _SLModel[1];
                    g = SLModel[2];
                    h = _SLModel[2];
                    i = SLModel[3];
                    k = _SLModel[3];

                    ProgressShif1.Clear();
                    for (int i = 0; i < 2; i++)
                    {
                        ProgressShif1.Add(new OrderStatus() { Argument = SSTongShift[i], Value = TotalBasketPhantram[i] });
                    }
                    ProgressShift2.Clear();
                    for (int i = 0; i < 2; i++)
                    {
                        ProgressShift2.Add(new OrderStatus() { Argument = SSTongShift[i], Value = _SLModelPhantram[i] });
                    }


                    ProgressShift3.Clear();
                    for (int i = 0; i < 2; i++)
                    {
                        ProgressShift3.Add(new OrderStatus() { Argument = SSTongShift[i], Value = _SLModelPhantram[i + 2] });
                    }


                    ProgressShift4.Clear();
                    for (int i = 0; i < 2; i++)
                    {
                        ProgressShift4.Add(new OrderStatus() { Argument = SSTongShift[i], Value = _SLModelPhantram[i + 4] });
                    }

                    ProgressShift5.Clear();
                    for (int i = 0; i < 2; i++)
                    {
                        ProgressShift5.Add(new OrderStatus() { Argument = SSTongShift[i], Value = _SLModelPhantram[i + 6] });
                    }

                    StatictisHourShift1.Clear();
                    for (int i = 0; i < 8; i++)
                    {
                        StatictisHourShift1.Add(new OrderStatus() { Argument = Argumenthourday[i + 8], Value = valuedayShit[i] });
                        if (valuedayShit[i] > 0)
                        {
                            WordTime[0]++;
                        }
                    }
                    WordTime[1] = 8 - WordTime[0];
                    ProgressShiftTime.Clear();
                    for (int i = 0; i < 2; i++)
                    {
                        ProgressShiftTime.Add(new OrderStatus() { Argument = TimeLV[i], Value = WordTime[i] });
                    }

                    SSTotalShift[1] = SLModel[0] + SLModel[1] + SLModel[2] + SLModel[3];
                    SSTotalShift[0] = _SLModel[0] + _SLModel[1] + _SLModel[2] + _SLModel[3] - SSTotalShift[1];
                    l = SSTotalShift[1];
                    m = SSTotalShift[0] + SSTotalShift[1];
                    ProgressShiftTotalSL.Clear();
                    for (int i = 0; i < 2; i++)
                    {
                        ProgressShiftTotalSL.Add(new OrderStatus() { Argument = SSTongShift[i], Value = SSTotalShift[i] });
                    }
                }
                else if (IndexShift == 1)
                {

                    Shift = "Shift 2";
                    cmd = "SELECT * FROM DateShift2 where Ngay = '" + date + "' ";
                    DataTable TableHoya1 = new DataTable();
                    TableHoya1 = Sqlexcute.Read_Table_Group(cmd);
                    if (TableHoya1.Rows.Count > 0)
                    {
                        foreach (DataRow item in TableHoya1.Rows)
                        {
                            listShift.Add(new classlistshift() { Hour = (TimeSpan)item[2], Basket = (string)item[3], Model = (int)item[5], Quantity = (int)item[4] });
                            switch ((int)item[5])
                            {
                                case 1:
                                    TotalBasket[0]++;
                                    TotalBasket[1]++;
                                    _SLModel[0] += (int)item[4];
                                    SLModel[0] += (int)item[4];
                                    break;
                                case 2:
                                    TotalBasket[0]++;
                                    TotalBasket[1]++;

                                    _SLModel[1] += (int)item[4];
                                    SLModel[1] += (int)item[4];
                                    break;
                                case 3:
                                    TotalBasket[0]++;
                                    TotalBasket[1]++;
                                    _SLModel[2] += (int)item[4];
                                    SLModel[2] += (int)item[4];
                                    break;
                                case 4:

                                    TotalBasket[0]++;
                                    TotalBasket[1]++;

                                    _SLModel[3] += (int)item[4];
                                    SLModel[3] += (int)item[4];
                                    break;
                            }

                            TimeSpan hour = (TimeSpan)item[2];
                            switch (hour.Hours)
                            {
                                case 16:
                                    valuedayShit[0] += (int)item[4];
                                    break;
                                case 17:
                                    valuedayShit[1] += (int)item[4];
                                    break;
                                case 18:
                                    valuedayShit[2] += (int)item[4];
                                    break;
                                case 19:
                                    valuedayShit[3] += (int)item[4];
                                    break;
                                case 20:
                                    valuedayShit[4] += (int)item[4];
                                    break;
                                case 21:
                                    valuedayShit[5] += (int)item[4];
                                    break;
                                case 22:
                                    valuedayShit[6] += (int)item[4];
                                    break;
                                case 23:
                                    valuedayShit[7] += (int)item[4];
                                    break;
                            }

                        }
                    }
                    cmd = "SELECT * FROM DateShift1 where Ngay = '" + date + "' ";
                    TableHoya1 = Sqlexcute.Read_Table_Group(cmd);
                    if (TableHoya1.Rows.Count > 0)
                    {
                        foreach (DataRow item in TableHoya1.Rows)
                        {
                            switch ((int)item[5])
                            {
                                case 1:
                                    TotalBasket[0]++;
                                    _SLModel[0] += (int)item[4];
                                    break;
                                case 2:
                                    TotalBasket[0]++;
                                    _SLModel[1] += (int)item[4];
                                    break;
                                case 3:
                                    TotalBasket[0]++;
                                    _SLModel[2] += (int)item[4];
                                    break;
                                case 4:
                                    TotalBasket[0]++;
                                    _SLModel[3] += (int)item[4];
                                    break;
                            }
                        }
                    }
                    cmd = "SELECT * FROM DateShift3 where Ngay = '" + date + "' ";
                    TableHoya1 = Sqlexcute.Read_Table_Group(cmd);
                    if (TableHoya1.Rows.Count > 0)
                    {
                        foreach (DataRow item in TableHoya1.Rows)
                        {
                            switch ((int)item[5])
                            {
                                case 1:
                                    TotalBasket[0]++;
                                    _SLModel[0] += (int)item[4];
                                    break;
                                case 2:
                                    TotalBasket[0]++;
                                    _SLModel[1] += (int)item[4];
                                    break;
                                case 3:
                                    TotalBasket[0]++;
                                    _SLModel[2] += (int)item[4];
                                    break;
                                case 4:
                                    TotalBasket[0]++;
                                    _SLModel[3] += (int)item[4];
                                    break;
                            }
                        }
                    }
                    TotalBasketPhantram[1] = (double)TotalBasket[1] / (double)TotalBasket[0];
                    TotalBasketPhantram[0] = 1 - TotalBasketPhantram[1];
                    _SLModelPhantram[1] = (double)SLModel[0] / (double)_SLModel[0];
                    _SLModelPhantram[0] = 1 - _SLModelPhantram[1];
                    _SLModelPhantram[3] = (double)SLModel[1] / (double)_SLModel[1];
                    _SLModelPhantram[2] = 1 - _SLModelPhantram[3];
                    _SLModelPhantram[5] = (double)SLModel[2] / (double)_SLModel[2];
                    _SLModelPhantram[4] = 1 - _SLModelPhantram[5];
                    _SLModelPhantram[7] = (double)SLModel[3] / (double)_SLModel[3];
                    _SLModelPhantram[6] = 1 - _SLModelPhantram[7];
                    a = TotalBasket[1];
                    b = TotalBasket[0];
                    c = SLModel[0];
                    d = _SLModel[0];
                    e = SLModel[1];
                    f = _SLModel[1];
                    g = SLModel[2];
                    h = _SLModel[2];
                    i = SLModel[3];
                    k = _SLModel[3];
                    ProgressShif1.Clear();
                    for (int i = 0; i < 2; i++)
                    {
                        ProgressShif1.Add(new OrderStatus() { Argument = SSTongShift[i], Value = TotalBasketPhantram[i] });
                    }
                    ProgressShift2.Clear();
                    for (int i = 0; i < 2; i++)
                    {
                        ProgressShift2.Add(new OrderStatus() { Argument = SSTongShift[i], Value = _SLModelPhantram[i] });
                    }


                    ProgressShift3.Clear();
                    for (int i = 0; i < 2; i++)
                    {
                        ProgressShift3.Add(new OrderStatus() { Argument = SSTongShift[i], Value = _SLModelPhantram[i + 2] });
                    }


                    ProgressShift4.Clear();
                    for (int i = 0; i < 2; i++)
                    {
                        ProgressShift4.Add(new OrderStatus() { Argument = SSTongShift[i], Value = _SLModelPhantram[i + 4] });
                    }

                    ProgressShift5.Clear();
                    for (int i = 0; i < 2; i++)
                    {
                        ProgressShift5.Add(new OrderStatus() { Argument = SSTongShift[i], Value = _SLModelPhantram[i + 6] });
                    }

                    StatictisHourShift1.Clear();
                    for (int i = 0; i < 8; i++)
                    {
                        StatictisHourShift1.Add(new OrderStatus() { Argument = Argumenthourday[i + 16], Value = valuedayShit[i] });
                        if (valuedayShit[i] > 0)
                        {
                            WordTime[0]++;
                        }
                    }
                    WordTime[1] = 8 - WordTime[0];
                    ProgressShiftTime.Clear();
                    for (int i = 0; i < 2; i++)
                    {
                        ProgressShiftTime.Add(new OrderStatus() { Argument = TimeLV[i], Value = WordTime[i] });
                    }

                    SSTotalShift[1] = SLModel[0] + SLModel[1] + SLModel[2] + SLModel[3];
                    SSTotalShift[0] = _SLModel[0] + _SLModel[1] + _SLModel[2] + _SLModel[3] - SSTotalShift[1];
                    l = SSTotalShift[1];
                    m = SSTotalShift[0] + SSTotalShift[1];
                    ProgressShiftTotalSL.Clear();
                    for (int i = 0; i < 2; i++)
                    {
                        ProgressShiftTotalSL.Add(new OrderStatus() { Argument = SSTongShift[i], Value = SSTotalShift[i] });
                    }
                }
                else if (IndexShift == 2)
                {

                    Shift = "Shift 3";
                    cmd = "SELECT * FROM DateShift3 where Ngay = '" + date + "' ";
                    DataTable TableHoya1 = new DataTable();
                    TableHoya1 = Sqlexcute.Read_Table_Group(cmd);
                    if (TableHoya1.Rows.Count > 0)
                    {
                        foreach (DataRow item in TableHoya1.Rows)
                        {
                            listShift.Add(new classlistshift() { Hour = (TimeSpan)item[2], Basket = (string)item[3], Model = (int)item[5], Quantity = (int)item[4] });
                            switch ((int)item[5])
                            {
                                case 1:
                                    TotalBasket[0]++;
                                    TotalBasket[1]++;
                                    _SLModel[0] += (int)item[4];
                                    SLModel[0] += (int)item[4];
                                    break;
                                case 2:
                                    TotalBasket[0]++;
                                    TotalBasket[1]++;

                                    _SLModel[1] += (int)item[4];
                                    SLModel[1] += (int)item[4];
                                    break;
                                case 3:
                                    TotalBasket[0]++;
                                    TotalBasket[1]++;
                                    _SLModel[2] += (int)item[4];
                                    SLModel[2] += (int)item[4];
                                    break;
                                case 4:

                                    TotalBasket[0]++;
                                    TotalBasket[1]++;

                                    _SLModel[3] += (int)item[4];
                                    SLModel[3] += (int)item[4];
                                    break;
                            }
                            TimeSpan hour = (TimeSpan)item[2];
                            switch (hour.Hours)
                            {
                                case 0:
                                    valuedayShit[0] += (int)item[4];
                                    break;
                                case 1:
                                    valuedayShit[1] += (int)item[4];
                                    break;
                                case 2:
                                    valuedayShit[2] += (int)item[4];
                                    break;
                                case 3:
                                    valuedayShit[3] += (int)item[4];
                                    break;
                                case 4:
                                    valuedayShit[4] += (int)item[4];
                                    break;
                                case 5:
                                    valuedayShit[5] += (int)item[4];
                                    break;
                                case 6:
                                    valuedayShit[6] += (int)item[4];
                                    break;
                                case 7:
                                    valuedayShit[7] += (int)item[4];
                                    break;
                            }

                        }
                    }
                    cmd = "SELECT * FROM DateShift2 where Ngay = '" + date + "' ";
                    TableHoya1 = Sqlexcute.Read_Table_Group(cmd);
                    if (TableHoya1.Rows.Count > 0)
                    {
                        foreach (DataRow item in TableHoya1.Rows)
                        {
                            switch ((int)item[5])
                            {
                                case 1:
                                    TotalBasket[0]++;
                                    _SLModel[0] += (int)item[4];
                                    break;
                                case 2:
                                    TotalBasket[0]++;
                                    _SLModel[1] += (int)item[4];
                                    break;
                                case 3:
                                    TotalBasket[0]++;
                                    _SLModel[2] += (int)item[4];
                                    break;
                                case 4:
                                    TotalBasket[0]++;
                                    _SLModel[3] += (int)item[4];
                                    break;
                            }
                        }
                    }
                    cmd = "SELECT * FROM DateShift1 where Ngay = '" + date + "' ";
                    TableHoya1 = Sqlexcute.Read_Table_Group(cmd);
                    if (TableHoya1.Rows.Count > 0)
                    {
                        foreach (DataRow item in TableHoya1.Rows)
                        {
                            switch ((int)item[5])
                            {
                                case 1:
                                    TotalBasket[0]++;
                                    _SLModel[0] += (int)item[4];
                                    break;
                                case 2:
                                    TotalBasket[0]++;
                                    _SLModel[1] += (int)item[4];
                                    break;
                                case 3:
                                    TotalBasket[0]++;
                                    _SLModel[2] += (int)item[4];
                                    break;
                                case 4:
                                    TotalBasket[0]++;
                                    _SLModel[3] += (int)item[4];
                                    break;
                            }
                        }
                    }
                    TotalBasketPhantram[1] = (double)TotalBasket[1] / (double)TotalBasket[0];
                    TotalBasketPhantram[0] = 1 - TotalBasketPhantram[1];
                    _SLModelPhantram[1] = (double)SLModel[0] / (double)_SLModel[0];
                    _SLModelPhantram[0] = 1 - _SLModelPhantram[1];
                    _SLModelPhantram[3] = (double)SLModel[1] / (double)_SLModel[1];
                    _SLModelPhantram[2] = 1 - _SLModelPhantram[3];
                    _SLModelPhantram[5] = (double)SLModel[2] / (double)_SLModel[2];
                    _SLModelPhantram[4] = 1 - _SLModelPhantram[5];
                    _SLModelPhantram[7] = (double)SLModel[3] / (double)_SLModel[3];
                    _SLModelPhantram[6] = 1 - _SLModelPhantram[7];
                    a = TotalBasket[1];
                    b = TotalBasket[0];
                    c = SLModel[0];
                    d = _SLModel[0];
                    e = SLModel[1];
                    f = _SLModel[1];
                    g = SLModel[2];
                    h = _SLModel[2];
                    i = SLModel[3];
                    k = _SLModel[3];
                    ProgressShif1.Clear();
                    for (int i = 0; i < 2; i++)
                    {
                        ProgressShif1.Add(new OrderStatus() { Argument = SSTongShift[i], Value = TotalBasketPhantram[i] });
                    }
                    ProgressShift2.Clear();
                    for (int i = 0; i < 2; i++)
                    {
                        ProgressShift2.Add(new OrderStatus() { Argument = SSTongShift[i], Value = _SLModelPhantram[i] });
                    }


                    ProgressShift3.Clear();
                    for (int i = 0; i < 2; i++)
                    {
                        ProgressShift3.Add(new OrderStatus() { Argument = SSTongShift[i], Value = _SLModelPhantram[i + 2] });
                    }


                    ProgressShift4.Clear();
                    for (int i = 0; i < 2; i++)
                    {
                        ProgressShift4.Add(new OrderStatus() { Argument = SSTongShift[i], Value = _SLModelPhantram[i + 4] });
                    }

                    ProgressShift5.Clear();
                    for (int i = 0; i < 2; i++)
                    {
                        ProgressShift5.Add(new OrderStatus() { Argument = SSTongShift[i], Value = _SLModelPhantram[i + 6] });
                    }

                    StatictisHourShift1.Clear();
                    for (int i = 0; i < 8; i++)
                    {
                        StatictisHourShift1.Add(new OrderStatus() { Argument = Argumenthourday[i], Value = valuedayShit[i] });
                        if (valuedayShit[i] > 0)
                        {
                            WordTime[0]++;
                        }
                    }
                    WordTime[1] = 8 - WordTime[0];
                    ProgressShiftTime.Clear();
                    for (int i = 0; i < 2; i++)
                    {
                        ProgressShiftTime.Add(new OrderStatus() { Argument = TimeLV[i], Value = WordTime[i] });
                    }

                    SSTotalShift[1] = SLModel[0] + SLModel[1] + SLModel[2] + SLModel[3];
                    SSTotalShift[0] = _SLModel[0] + _SLModel[1] + _SLModel[2] + _SLModel[3] - SSTotalShift[1];
                    l = SSTotalShift[1];
                    m = SSTotalShift[0] + SSTotalShift[1];
                    ProgressShiftTotalSL.Clear();
                    for (int i = 0; i < 2; i++)
                    {
                        ProgressShiftTotalSL.Add(new OrderStatus() { Argument = SSTongShift[i], Value = SSTotalShift[i] });
                    }
                }

                StatictisHourShift.Clear();
                for (int i = 0; i < 4; i++)
                {
                    StatictisHourShift.Add(new OrderStatus() { Argument = ArgumentModel[i], Value = SLModel[i] });
                }
                #region homqua
                //date = DateTime.Today.AddDays(-1).ToString("yyyy-MM-dd");
                //if (IndexShift == 0)
                //{
                //    valuedayShit = new int[8];
                //    cmd = "SELECT * FROM DateShift1 where Ngay = '" + date + "' ";
                //    DataTable TableHoya1 = new DataTable();
                //    TableHoya1 = Sqlexcute.Read_Table_Group(cmd);
                //    foreach (DataRow item in TableHoya1.Rows)
                //    {
                //        TimeSpan hour = (TimeSpan)item[2];
                //        switch (hour.Hours)
                //        {
                //            case 8:
                //                valuedayShit[0] += (int)item[4];
                //                break;
                //            case 9:
                //                valuedayShit[1] += (int)item[4];
                //                break;
                //            case 10:
                //                valuedayShit[2] += (int)item[4];
                //                break;
                //            case 11:
                //                valuedayShit[3] += (int)item[4];
                //                break;
                //            case 12:
                //                valuedayShit[4] += (int)item[4];
                //                break;
                //            case 13:
                //                valuedayShit[5] += (int)item[4];
                //                break;
                //            case 14:
                //                valuedayShit[6] += (int)item[4];
                //                break;
                //            case 15:
                //                valuedayShit[7] += (int)item[4];
                //                break;
                //        }
                //    }
                //    YesterdayStatictisHourShift1 = new ObservableCollection<OrderStatus>();
                //    for (int i = 0; i < 8; i++)
                //    {
                //        YesterdayStatictisHourShift1.Add(new OrderStatus() { Argument = Argumenthourday[i + 8], Value = valuedayShit[i] });

                //    }
                //}
                //if (IndexShift == 1)
                //{
                //    valuedayShit = new int[8];
                //    cmd = "SELECT * FROM DateShift2 where Ngay = '" + date + "' ";
                //    DataTable TableHoya1 = new DataTable();
                //    TableHoya1 = Sqlexcute.Read_Table_Group(cmd);
                //    foreach (DataRow item in TableHoya1.Rows)
                //    {
                //        TimeSpan hour = (TimeSpan)item[2];
                //        switch (hour.Hours)
                //        {
                //            case 16:
                //                valuedayShit[0] += (int)item[4];
                //                break;
                //            case 17:
                //                valuedayShit[1] += (int)item[4];
                //                break;
                //            case 18:
                //                valuedayShit[2] += (int)item[4];
                //                break;
                //            case 19:
                //                valuedayShit[3] += (int)item[4];
                //                break;
                //            case 20:
                //                valuedayShit[4] += (int)item[4];
                //                break;
                //            case 21:
                //                valuedayShit[5] += (int)item[4];
                //                break;
                //            case 22:
                //                valuedayShit[6] += (int)item[4];
                //                break;
                //            case 23:
                //                valuedayShit[7] += (int)item[4];
                //                break;
                //        }
                //    }
                //    YesterdayStatictisHourShift1 = new ObservableCollection<OrderStatus>();
                //    for (int i = 0; i < 8; i++)
                //    {
                //        YesterdayStatictisHourShift1.Add(new OrderStatus() { Argument = Argumenthourday[i + 16], Value = valuedayShit[i] });

                //    }
                //}
                //if (IndexShift == 2)
                //{
                //    valuedayShit = new int[8];
                //    cmd = "SELECT * FROM DateShift3 where Ngay = '" + date + "' ";
                //    DataTable TableHoya1 = new DataTable();
                //    TableHoya1 = Sqlexcute.Read_Table_Group(cmd);
                //    foreach (DataRow item in TableHoya1.Rows)
                //    {
                //        TimeSpan hour = (TimeSpan)item[2];
                //        switch (hour.Hours)
                //        {
                //            case 0:
                //                valuedayShit[0] += (int)item[4];
                //                break;
                //            case 1:
                //                valuedayShit[1] += (int)item[4];
                //                break;
                //            case 2:
                //                valuedayShit[2] += (int)item[4];
                //                break;
                //            case 3:
                //                valuedayShit[3] += (int)item[4];
                //                break;
                //            case 4:
                //                valuedayShit[4] += (int)item[4];
                //                break;
                //            case 5:
                //                valuedayShit[5] += (int)item[4];
                //                break;
                //            case 6:
                //                valuedayShit[6] += (int)item[4];
                //                break;
                //            case 7:
                //                valuedayShit[7] += (int)item[4];
                //                break;
                //        }
                //    }
                //    YesterdayStatictisHourShift1 = new ObservableCollection<OrderStatus>();
                //    for (int i = 0; i < 8; i++)
                //    {
                //        YesterdayStatictisHourShift1.Add(new OrderStatus() { Argument = Argumenthourday[i], Value = valuedayShit[i] });

                //    }
                //}
                #endregion



                //////
            }
            catch (Exception EX)
            {
                MessageBox.Show(EX.Message);
            }
        }

        public class OrderStatus
        {
            public string Argument { get; set; }
            public double Value { get; set; }
        }
        public class OrderStatus1
        {
            public TimeSpan Argument { get; set; }
            public double Value { get; set; }
        }
        public class Classlist1
        {
            public TimeSpan Hour { get; set; }
            public int Model { get; set; }
            public int Quantity { get; set; }
        }
        public class classlistshift
        {
            public TimeSpan Hour { get; set; }
            public int Model { get; set; }
            public int Quantity { get; set; }
            public string Basket { get; set; }
        }
        public class DataSeries
        {
            public string Name { get; set; }
            public ObservableCollection<Comparepoint> Values { get; set; }
        }
        public class Comparepoint
        {
            public string Argument { get; set; }
            public double Value { get; set; }

            public Comparepoint(string argument, double value)
            {
                Argument = argument;
                Value = value;
            }
        }
        public async void chayngam3()
        {
            void act()
            {
                DateTime timenow = DateTime.Now;
                int hour = timenow.Hour;
                string Gio = timenow.ToString("HH:mm:ss");
                string Ngay = timenow.ToString("yyyy-MM-dd");
                string QR = "1";


                if (hour >= 8 && hour < 16)
                {

                    _ = Sqlexcute.SQL_command("INSERT INTO `Dateshift1`(`Ngay`, `Gio`, `QR_RACK`, `SoLuongKinh`, `Model`) VALUES ('" + Ngay + "','" + Gio + "' , '" + QR + "', '" + 20 + "','" + 2 + "')", MySQLDaTaHoya.Database);


                }
                if (hour >= 16 && hour < 24)
                {
                    _ = Sqlexcute.SQL_command("INSERT INTO `Dateshift2`(`Ngay`, `Gio`, `QR_RACK`, `SoLuongKinh`, `Model`) VALUES ('" + Ngay + "','" + Gio + "' , '" + QR + "', '" + 20 + "','" + 1 + "')", MySQLDaTaHoya.Database);

                }
                if (hour >= 0 && hour < 8)
                {
                    _ = Sqlexcute.SQL_command("INSERT INTO `Dateshift3`(`Ngay`, `Gio`, `QR_RACK`, `SoLuongKinh`, `Model`) VALUES ('" + Ngay + "','" + Gio + "' , '" + QR + "', '" + 20 + "','" + 3 + "')", MySQLDaTaHoya.Database);

                }


            }
            var a = new Task(act);
            a.Start();
            await a;
        }
    }
}
