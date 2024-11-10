using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media.Animation;
using System.Windows.Media.Media3D;

namespace VNC.Core.Xaml.Transitions
{
    /// <summary>
    /// Interaction logic for Rotate3D.xaml
    /// </summary>

    public partial class Rotate3D : Grid
    {

        public Rotate3D()
        {
            InitializeComponent();
        }

         private void OnLoaded(object sender, EventArgs e)
        {
            // Get the mesh objects for changing the material
            ModelVisual3D mv3d = myViewport3D.Children[0] as ModelVisual3D;
            Model3DGroup m3dgBase = mv3d.Content as Model3DGroup;

            Model3DGroup m3dg = m3dgBase.Children[0] as Model3DGroup;
            _FrontPlane = m3dg.Children[0] as GeometryModel3D;
            _BackPlane = m3dg.Children[1] as GeometryModel3D;

        }

        #region Dependecy Properties

        #region Dependency Properties AngleRotateTo

        public static readonly DependencyProperty AngleRotateToProperty = DependencyProperty.RegisterAttached("AngleRotateTo",
            typeof(Double), typeof(Rotate3D), new FrameworkPropertyMetadata((Double)0, new PropertyChangedCallback(AngleRotateToInvalidated)));

        public static Double GetAngleRotateTo(DependencyObject d)
        {
            return (Double)(d.GetValue(Rotate3D.AngleRotateToProperty));
        }

        public static void SetAngleRotateTo(DependencyObject d, Double value)
        {
            d.SetValue(Rotate3D.AngleRotateToProperty, value);
        }

        private static void AngleRotateToInvalidated(DependencyObject target, DependencyPropertyChangedEventArgs e)
        {
            if (target == null)
                return;
        }
        #endregion

        #region Dependency Properties AngleRotateFrom

        public static readonly DependencyProperty AngleRotateFromProperty = DependencyProperty.RegisterAttached("AngleRotateFrom",
            typeof(Double), typeof(Rotate3D), new FrameworkPropertyMetadata((Double)0, new PropertyChangedCallback(AngleRotateFromInvalidated)));

        public static Double GetAngleRotateFrom(DependencyObject d)
        {
            return (Double)(d.GetValue(Rotate3D.AngleRotateFromProperty));
        }

        public static void SetAngleRotateFrom(DependencyObject d, Double value)
        {
            d.SetValue(Rotate3D.AngleRotateFromProperty, value);
        }

        private static void AngleRotateFromInvalidated(DependencyObject target, DependencyPropertyChangedEventArgs e)
        {
            if (target == null)
                return;
        }
        #endregion

        #region Dependency Properties FrontMaterial

        public static readonly DependencyProperty FrontMaterialProperty = DependencyProperty.RegisterAttached("FrontMaterial",
            typeof(Material), typeof(Rotate3D), new FrameworkPropertyMetadata((Material)null, new PropertyChangedCallback(FrontMaterialInvalidated)));

        public static Material GetFrontMaterial(DependencyObject d)
        {
            return (Material)(d.GetValue(Rotate3D.FrontMaterialProperty));
        }

        public static void SetFrontMaterial(DependencyObject d, Material value)
        {
            d.SetValue(Rotate3D.FrontMaterialProperty, value);
        }

        private static void FrontMaterialInvalidated(DependencyObject target, DependencyPropertyChangedEventArgs e)
        {
            if (target == null)
                return;
        }
        #endregion

        #region Dependency Properties BackMaterial

        public static readonly DependencyProperty BackMaterialProperty = DependencyProperty.RegisterAttached("BackMaterial",
            typeof(Material), typeof(Rotate3D), new FrameworkPropertyMetadata((Material)null, new PropertyChangedCallback(BackMaterialInvalidated)));

        public static Material GetBackMaterial(DependencyObject d)
        {
            return (Material)(d.GetValue(Rotate3D.BackMaterialProperty));
        }

        public static void SetBackMaterial(DependencyObject d, Material value)
        {
            d.SetValue(Rotate3D.BackMaterialProperty, value);
        }

        private static void BackMaterialInvalidated(DependencyObject target, DependencyPropertyChangedEventArgs e)
        {
            if (target == null)
                return;
        }
        #endregion

        #region Dependency Properties ScaleX

        public static readonly DependencyProperty ScaleXProperty = DependencyProperty.RegisterAttached("ScaleX",
            typeof(Double), typeof(Rotate3D), new FrameworkPropertyMetadata((Double)1.0, new PropertyChangedCallback(ScaleXInvalidated)));

        public static Double GetScaleX(DependencyObject d)
        {
            return (Double)(d.GetValue(Rotate3D.ScaleXProperty));
        }

        public static void SetScaleX(DependencyObject d, Double value)
        {
            d.SetValue(Rotate3D.ScaleXProperty, value);
        }

        private static void ScaleXInvalidated(DependencyObject target, DependencyPropertyChangedEventArgs e)
        {
            if (target == null)
                return;
        }
        #endregion

        #region Dependency Properties ScaleY

        public static readonly DependencyProperty ScaleYProperty = DependencyProperty.RegisterAttached("ScaleY",
            typeof(Double), typeof(Rotate3D), new FrameworkPropertyMetadata((Double)1.0, new PropertyChangedCallback(ScaleYInvalidated)));

        public static Double GetScaleY(DependencyObject d)
        {
            return (Double)(d.GetValue(Rotate3D.ScaleYProperty));
        }

        public static void SetScaleY(DependencyObject d, Double value)
        {
            d.SetValue(Rotate3D.ScaleYProperty, value);
        }

        private static void ScaleYInvalidated(DependencyObject target, DependencyPropertyChangedEventArgs e)
        {
            if (target == null)
                return;
        }
        #endregion

        #region Dependency Properties TranslateX

        public static readonly DependencyProperty TranslateXProperty = DependencyProperty.RegisterAttached("TranslateX",
            typeof(Double), typeof(Rotate3D), new FrameworkPropertyMetadata((Double)0.0, new PropertyChangedCallback(TranslateXInvalidated)));

        public static Double GetTranslateX(DependencyObject d)
        {
            return (Double)(d.GetValue(Rotate3D.TranslateXProperty));
        }

        public static void SetTranslateX(DependencyObject d, Double value)
        {
            d.SetValue(Rotate3D.TranslateXProperty, value);
        }

        private static void TranslateXInvalidated(DependencyObject target, DependencyPropertyChangedEventArgs e)
        {
            if (target == null)
                return;
        }
        #endregion

        #region Dependency Properties TranslateY

        public static readonly DependencyProperty TranslateYProperty = DependencyProperty.RegisterAttached("TranslateY",
            typeof(Double), typeof(Rotate3D), new FrameworkPropertyMetadata((Double)0.0, new PropertyChangedCallback(TranslateYInvalidated)));

        public static Double GetTranslateY(DependencyObject d)
        {
            return (Double)(d.GetValue(Rotate3D.TranslateYProperty));
        }

        public static void SetTranslateY(DependencyObject d, Double value)
        {
            d.SetValue(Rotate3D.TranslateYProperty, value);
        }

        private static void TranslateYInvalidated(DependencyObject target, DependencyPropertyChangedEventArgs e)
        {
            if (target == null)
                return;
        }
        #endregion

        #region Dependency Properties ScaleXBack

        public static readonly DependencyProperty ScaleXBackProperty = DependencyProperty.RegisterAttached("ScaleXBack",
            typeof(Double), typeof(Rotate3D), new FrameworkPropertyMetadata((Double)1.0, new PropertyChangedCallback(ScaleXBackInvalidated)));

        public static Double GetScaleXBack(DependencyObject d)
        {
            return (Double)(d.GetValue(Rotate3D.ScaleXBackProperty));
        }

        public static void SetScaleXBack(DependencyObject d, Double value)
        {
            d.SetValue(Rotate3D.ScaleXBackProperty, value);
        }

        private static void ScaleXBackInvalidated(DependencyObject target, DependencyPropertyChangedEventArgs e)
        {
            if (target == null)
                return;
        }
        #endregion

        #region Dependency Properties ScaleYBack

        public static readonly DependencyProperty ScaleYBackProperty = DependencyProperty.RegisterAttached("ScaleYBack",
            typeof(Double), typeof(Rotate3D), new FrameworkPropertyMetadata((Double)1.0, new PropertyChangedCallback(ScaleYBackInvalidated)));

        public static Double GetScaleYBack(DependencyObject d)
        {
            return (Double)(d.GetValue(Rotate3D.ScaleYBackProperty));
        }

        public static void SetScaleYBack(DependencyObject d, Double value)
        {
            d.SetValue(Rotate3D.ScaleYBackProperty, value);
        }

        private static void ScaleYBackInvalidated(DependencyObject target, DependencyPropertyChangedEventArgs e)
        {
            if (target == null)
                return;
        }
        #endregion

        #region Dependency Properties TranslateXBackBack

        public static readonly DependencyProperty TranslateXBackProperty = DependencyProperty.RegisterAttached("TranslateXBack",
            typeof(Double), typeof(Rotate3D), new FrameworkPropertyMetadata((Double)0.0, new PropertyChangedCallback(TranslateXBackInvalidated)));

        public static Double GetTranslateXBack(DependencyObject d)
        {
            return (Double)(d.GetValue(Rotate3D.TranslateXBackProperty));
        }

        public static void SetTranslateXBack(DependencyObject d, Double value)
        {
            d.SetValue(Rotate3D.TranslateXBackProperty, value);
        }

        private static void TranslateXBackInvalidated(DependencyObject target, DependencyPropertyChangedEventArgs e)
        {
            if (target == null)
                return;
        }
        #endregion

        #region Dependency Properties TranslateYBack

        public static readonly DependencyProperty TranslateYBackProperty = DependencyProperty.RegisterAttached("TranslateYBack",
            typeof(Double), typeof(Rotate3D), new FrameworkPropertyMetadata((Double)0.0, new PropertyChangedCallback(TranslateYBackInvalidated)));

        public static Double GetTranslateYBack(DependencyObject d)
        {
            return (Double)(d.GetValue(Rotate3D.TranslateYBackProperty));
        }

        public static void SetTranslateYBack(DependencyObject d, Double value)
        {
            d.SetValue(Rotate3D.TranslateYBackProperty, value);
        }

        private static void TranslateYBackInvalidated(DependencyObject target, DependencyPropertyChangedEventArgs e)
        {
            if (target == null)
                return;
        }
        #endregion

        #region Dependency Properties ScaleXTo

        public static readonly DependencyProperty ScaleXToProperty = DependencyProperty.RegisterAttached("ScaleXTo",
            typeof(Double), typeof(Rotate3D), new FrameworkPropertyMetadata((Double)1.0, new PropertyChangedCallback(ScaleXToInvalidated)));

        public static Double GetScaleXTo(DependencyObject d)
        {
            return (Double)(d.GetValue(Rotate3D.ScaleXToProperty));
        }

        public static void SetScaleXTo(DependencyObject d, Double value)
        {
            d.SetValue(Rotate3D.ScaleXToProperty, value);
        }

        private static void ScaleXToInvalidated(DependencyObject target, DependencyPropertyChangedEventArgs e)
        {
            if (target == null)
                return;
        }
        #endregion

        #region Dependency Properties ScaleYTo

        public static readonly DependencyProperty ScaleYToProperty = DependencyProperty.RegisterAttached("ScaleYTo",
            typeof(Double), typeof(Rotate3D), new FrameworkPropertyMetadata((Double)1.0, new PropertyChangedCallback(ScaleYToInvalidated)));

        public static Double GetScaleYTo(DependencyObject d)
        {
            return (Double)(d.GetValue(Rotate3D.ScaleYToProperty));
        }

        public static void SetScaleYTo(DependencyObject d, Double value)
        {
            d.SetValue(Rotate3D.ScaleYToProperty, value);
        }

        private static void ScaleYToInvalidated(DependencyObject target, DependencyPropertyChangedEventArgs e)
        {
            if (target == null)
                return;
        }
        #endregion

        #region Dependency Properties TranslateXTo

        public static readonly DependencyProperty TranslateXToProperty = DependencyProperty.RegisterAttached("TranslateXTo",
            typeof(Double), typeof(Rotate3D), new FrameworkPropertyMetadata((Double)1.0, new PropertyChangedCallback(TranslateXToInvalidated)));

        public static Double GetTranslateXTo(DependencyObject d)
        {
            return (Double)(d.GetValue(Rotate3D.TranslateXToProperty));
        }

        public static void SetTranslateXTo(DependencyObject d, Double value)
        {
            d.SetValue(Rotate3D.TranslateXToProperty, value);
        }

        private static void TranslateXToInvalidated(DependencyObject target, DependencyPropertyChangedEventArgs e)
        {
            if (target == null)
                return;
        }
             #endregion

        #region Dependency Properties DurationTime

        public static readonly DependencyProperty DurationTimeProperty = DependencyProperty.RegisterAttached("DurationTime",
            typeof(Double), typeof(Rotate3D), new FrameworkPropertyMetadata((Double)0.0, new PropertyChangedCallback(DurationTimeInvalidated)));

        public static Double GetDurationTime(DependencyObject d)
        {
            return (Double)(d.GetValue(Rotate3D.DurationTimeProperty));
        }

        public static void SetDurationTime(DependencyObject d, Double value)
        {
            d.SetValue(Rotate3D.DurationTimeProperty, value);
        }

        private static void DurationTimeInvalidated(DependencyObject target, DependencyPropertyChangedEventArgs e)
        {
            if (target == null)
                return;
        }
        #endregion
        #endregion

        #region Event Handlers

        public delegate void SelectedEventHandler(object sender, EventArgs e);

        public event SelectedEventHandler RotateCompleted;
        protected virtual void OnRotateCompleted(object o, EventArgs e)
        {
            if (RotateCompleted != null)
                RotateCompleted(o, e);
        }

        #endregion Event Handlers

        #region Events

        private void OnRotateStoryboard(object sender, EventArgs e)
        {
            Clock TimelineClock = (Clock)sender;

            // Started Clock
            if (TimelineClock.CurrentState == ClockState.Active)
            {

            }

            // Ended Clock
            if ((TimelineClock.CurrentState != ClockState.Active))
            {
                OnRotateCompleted(null, new EventArgs());
            }
        }

        #endregion

        #region Properties
        #endregion

        #region Public Methods

        public void Rotate()
        {
            Storyboard s = (Storyboard)this.FindResource("RotateStoryboard");

            // elementbinding doesn't work in Beta bits. So create the animation in code for now
            ParallelTimeline pt = s.Children[0] as ParallelTimeline;
            pt.Children.Clear();
            //Double from = (Double)this.GetValue(Rotate3D.AngleRotateFromProperty);
            Double to = (Double)this.GetValue(Rotate3D.AngleRotateToProperty);
            Double duration = (Double)this.GetValue(Rotate3D.DurationTimeProperty);
            pt.Children.Add(new DoubleAnimation(to, new Duration(TimeSpan.FromSeconds(duration)),FillBehavior.HoldEnd));

            this.BeginStoryboard(s);
        }

        public void AnimateScaleXTo(Double to)
        {
            Storyboard s = (Storyboard)this.FindResource("ScaleXStoryboard");

            // elementbinding doesn't work in Beta bits. So create the animation in code for now
            ParallelTimeline pt = s.Children[0] as ParallelTimeline;
            pt.Children.Clear();
            Double duration = (Double)this.GetValue(Rotate3D.DurationTimeProperty);
            pt.Children.Add(new DoubleAnimation(to, new Duration(TimeSpan.FromSeconds(duration)), FillBehavior.HoldEnd));

            this.BeginStoryboard(s);
        }

        public void AnimateScaleYTo(Double to)
        {
            Storyboard s = (Storyboard)this.FindResource("ScaleYStoryboard");

            // elementbinding doesn't work in Beta bits. So create the animation in code for now
            ParallelTimeline pt = s.Children[0] as ParallelTimeline;
            pt.Children.Clear();
            Double duration = (Double)this.GetValue(Rotate3D.DurationTimeProperty);
            pt.Children.Add(new DoubleAnimation(to, new Duration(TimeSpan.FromSeconds(duration)), FillBehavior.HoldEnd));

            this.BeginStoryboard(s);
        }


        public void AnimateTranslateXTo(Double to)
        {
            Storyboard s = (Storyboard)this.FindResource("TranslateXStoryboard");

            // elementbinding doesn't work in Beta bits. So create the animation in code for now
            ParallelTimeline pt = s.Children[0] as ParallelTimeline;
            pt.Children.Clear();
            Double duration = (Double)this.GetValue(Rotate3D.DurationTimeProperty);
            pt.Children.Add(new DoubleAnimation(to, new Duration(TimeSpan.FromSeconds(duration)), FillBehavior.HoldEnd));

            this.BeginStoryboard(s);
        }

        #endregion

        #region Private Methods


        #endregion

        #region Globals

        // Geometry models
        GeometryModel3D _FrontPlane;
        GeometryModel3D _BackPlane;

        #endregion
    }

 }