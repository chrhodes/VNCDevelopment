﻿using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media.Animation;
using System.Windows.Media.Media3D;


namespace VNC.Core.Xaml.Transitions
{
    public partial class Flip3D : Grid
    {
        public Flip3D()
        {
            InitializeComponent();
        }

        void OnInitialized(object sender, EventArgs e)
        {
        }

        private void OnLoaded(object sender, EventArgs e)
        {
            
            // Get the mesh objects for changing the material
            ModelVisual3D mv3d = myViewport3D.Children[0] as ModelVisual3D;
            Model3DGroup m3dgBase = mv3d.Content as Model3DGroup;

            Model3DGroup m3dg = m3dgBase.Children[0] as Model3DGroup;
            _TopPlane = m3dg.Children[0] as GeometryModel3D;
            _BottomPlane = m3dg.Children[1] as GeometryModel3D;

            m3dg = m3dgBase.Children[1] as Model3DGroup;
            _FrontSpinPlane = m3dg.Children[0] as GeometryModel3D;
            _BackSpinPlane = m3dg.Children[1] as GeometryModel3D;

            _TransparentMaterial = this.FindResource("TransparentMaterial") as DiffuseMaterial;
            

        }

        #region Dependecy Properties

        #region Dependency Properties ScaleX

        public static readonly DependencyProperty ScaleXProperty = DependencyProperty.RegisterAttached("ScaleX",
            typeof(Double), typeof(Flip3D), new FrameworkPropertyMetadata((Double)1.0, new PropertyChangedCallback(ScaleXInvalidated)));

        public static Double GetScaleX(DependencyObject d)
        {
            return (Double)(d.GetValue(Flip3D.ScaleXProperty));
        }

        public static void SetScaleX(DependencyObject d, Double value)
        {
            d.SetValue(Flip3D.ScaleXProperty, value);
        }

        private static void ScaleXInvalidated(DependencyObject target, DependencyPropertyChangedEventArgs e)
        {
            if (target == null)
                return;
        }
        #endregion

        #region Dependency Properties ScaleY

        public static readonly DependencyProperty ScaleYProperty = DependencyProperty.RegisterAttached("ScaleY",
            typeof(Double), typeof(Flip3D), new FrameworkPropertyMetadata((Double)1.0, new PropertyChangedCallback(ScaleYInvalidated)));

        public static Double GetScaleY(DependencyObject d)
        {
            return (Double)(d.GetValue(Flip3D.ScaleYProperty));
        }

        public static void SetScaleY(DependencyObject d, Double value)
        {
            d.SetValue(Flip3D.ScaleYProperty, value);
        }

        private static void ScaleYInvalidated(DependencyObject target, DependencyPropertyChangedEventArgs e)
        {
            if (target == null)
                return;
        }
        #endregion

        #region Dependency Properties TranslateX

        public static readonly DependencyProperty TranslateXProperty = DependencyProperty.RegisterAttached("TranslateX",
            typeof(Double), typeof(Flip3D), new FrameworkPropertyMetadata((Double)0.0, new PropertyChangedCallback(TranslateXInvalidated)));

        public static Double GetTranslateX(DependencyObject d)
        {
            return (Double)(d.GetValue(Flip3D.TranslateXProperty));
        }

        public static void SetTranslateX(DependencyObject d, Double value)
        {
            d.SetValue(Flip3D.TranslateXProperty, value);
        }

        private static void TranslateXInvalidated(DependencyObject target, DependencyPropertyChangedEventArgs e)
        {
            if (target == null)
                return;
        }
        #endregion

        #region Dependency Properties TranslateY

        public static readonly DependencyProperty TranslateYProperty = DependencyProperty.RegisterAttached("TranslateY",
            typeof(Double), typeof(Flip3D), new FrameworkPropertyMetadata((Double)0.0, new PropertyChangedCallback(TranslateYInvalidated)));

        public static Double GetTranslateY(DependencyObject d)
        {
            return (Double)(d.GetValue(Flip3D.TranslateYProperty));
        }

        public static void SetTranslateY(DependencyObject d, Double value)
        {
            d.SetValue(Flip3D.TranslateYProperty, value);
        }

        private static void TranslateYInvalidated(DependencyObject target, DependencyPropertyChangedEventArgs e)
        {
            if (target == null)
                return;
        }
        #endregion

        #endregion

        #region Properties

        #endregion

        #region Event Handlers

        public delegate void SelectedEventHandler(object sender, EventArgs e);

        public event SelectedEventHandler FlipCompleted;
        protected virtual void OnFlipCompleted(object o, EventArgs e)
        {
            if (FlipCompleted != null)
                FlipCompleted(o, e);
        }

        #endregion Event Handlers

        #region Events

        private void OnFlipTimeline(object sender, EventArgs e)
        {
            Clock TimelineClock = (Clock)sender;

            // Started Clock
            if (TimelineClock.CurrentState == ClockState.Active)
            {
                
            }

            // Ended Clock
            if ((TimelineClock.CurrentState != ClockState.Active))
            {
                OnFlipCompleted(null, new EventArgs());
            }
        }

        #endregion

        #region Public Methods

        public void Flip(DiffuseMaterial dmFrom, DiffuseMaterial dmTo)
        {
            
            if (_TopPlane == null)
                return;

            _TopPlane.Material = _TransparentMaterial;
            _BottomPlane.Material = _TransparentMaterial;
            _FrontSpinPlane.Material = dmFrom;
            _BackSpinPlane.Material = dmFrom;

            Storyboard s = (Storyboard)this.FindResource("FlipPicTimeline");
            this.BeginStoryboard(s);
            
        }

        #endregion

        #region Private Methods

        #endregion

        #region Globals

        // Geometry models
        GeometryModel3D _TopPlane;
        GeometryModel3D _BottomPlane;
        GeometryModel3D _FrontSpinPlane;
        GeometryModel3D _BackSpinPlane;

        DiffuseMaterial _TransparentMaterial;

        #endregion
    }

    

}


