using System.ComponentModel;

namespace FinanceTrack.CustomTools
{
    public class CollapsePanel : FlowLayoutPanel
    {
        [Category("Collapse")]
        [DefaultValue(TypeDirection.Verticale)]
        [Description("Направление сворачивания\\разворачивания")]
        public TypeDirection Direction { get; set; } = TypeDirection.Verticale;

        [Category("Collapse")]
        [DefaultValue(0)]
        [Description("Минимальный горизонтальный размер (обязателен при горизонтальном использовании)")]
        public int HorizontalMinSize { get; set; } = 0;

        [Category("Collapse")]
        [DefaultValue(50)]
        [Description("Время в милесекундах на сворачивания\\разворачивания")]
        public int TimeCollapse { get; set; } = 50;

        [Category("Collapse")]
        [DefaultValue(10)]
        [Description("Интервал между подсчетами сворачивания\\разворачивания")]
        public int TimerInterval { get; set; } = 10;

        [Category("Collapse")]
        [DefaultValue(StateCollapse.Collapse)]
        [Description("Первоначальное состояние сворачивания\\разворачивания")]
        public StateCollapse InitialView { get; set; } = StateCollapse.Collapse;

        public enum StateCollapse
        {
            /// <summary>
            /// Свернутый
            /// </summary>
            Collapse,
            /// <summary>
            /// Развернутый
            /// </summary>
            Expanded
        }

        public enum TypeDirection
        {
            Hirizontal,
            Verticale
        }

        private System.Windows.Forms.Timer _timer;

        private int _minSize;
        private int _maxSize;
        private float _stepChnagSize = -1;

        /// <summary>
        /// Свернут
        /// </summary>
        bool _isCollapsed = false;
        private float _cunnertSize;

        public CollapsePanel()
        {
            _timer = new();
            _timer.Interval = TimerInterval;
            _timer.Tick += _timer_Tick;
        }

        public void ExecuteCollapse()
        {
            if (_stepChnagSize == -1)
            {
                InicializationStartParametrs();
            }

            if (_timer.Enabled)
                _isCollapsed = !_isCollapsed;

            _timer.Start();
        }

        /// <summary>
        /// Нужно вызвать данный метод после загрузки формы, для того чтобы применить начальное свойство <see cref="InitialView"/>
        /// </summary>
        public void InicializationStartParametrs()
        {
            Button? button = null;
            foreach (object? control in Controls)
            {
                if (control is Button)
                {
                    button = (Button)control;
                }
            } 

            if (button == null)
                return;

            if (Direction == TypeDirection.Hirizontal)
            {
                _minSize = HorizontalMinSize;
                _maxSize = Width;
            }
            else
            {
                _minSize = button.Size.Height;
                _maxSize = button.Size.Height * Controls.Count;
            }

            _cunnertSize = InitialView == StateCollapse.Collapse ? _minSize : _maxSize;
            _stepChnagSize = (_maxSize - _minSize) / ((float)TimeCollapse / TimerInterval);

            _isCollapsed = InitialView == StateCollapse.Collapse;

            if (Direction == TypeDirection.Hirizontal)
                Width = (int)_cunnertSize;
            else
                Height = (int)_cunnertSize;
        }

        private void _timer_Tick(object? sender, EventArgs e)
        {
            if (_isCollapsed)
            {
                _cunnertSize += _stepChnagSize;
                if (_cunnertSize >= _maxSize)
                {
                    _cunnertSize = _maxSize;
                    _timer.Stop();
                    _isCollapsed = false;
                }
            }
            else
            {
                _cunnertSize -= _stepChnagSize;
                if (_cunnertSize <= _minSize)
                {
                    _cunnertSize = _minSize;
                    _timer.Stop();
                    _isCollapsed = true;
                }
            }

            if (Direction == TypeDirection.Hirizontal)
                Width = (int)_cunnertSize;
            else
                Height = (int)_cunnertSize;
        }
    }
}
