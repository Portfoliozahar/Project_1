   M S B A M L   `   `   `  ���� B  >Project, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null!clr-namespace:ProjectProject      Project.MainWindow   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     @d2http://schemas.microsoft.com/expression/blend/2008     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     'localclr-namespace:Project     _ [MaterialDesignThemes.Wpf, Version=4.9.0.0, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  -   $	��600��$
��1200��  � WindowStartupLocation$  CenterScreen=�$6��0/Project;component/Fonts/#Champagne & Limousines)� � Icon$ Assets/log.jpg�� � WindowState$ 	Maximized=�$	��550��$
��1080�� � 	Resources    	CloseMenu �� TargetProperty �� 
TargetName9  3System.Windows.Media.Animation.EasingDoubleKeyFrame O� KeyTime O� Value   EasingFunction-  'System.Windows.Media.Animation.BackEase7  1System.Windows.Media.Animation.EasingFunctionBase	   
EasingMode
   	Amplitude  OpenMenu��%�  &	        &	 �     �� .��U� $U O(UIElement.RenderTransform).(TransformGroup.Children)[3].(TranslateTransform.X)�$ 	StackMenu��.\�  $ 0��$	 250Q�  $ 0:0:0.5��$ 0Q�   $	 EaseIn=�$
 -3Q��� .��U� $U O(UIElement.RenderTransform).(TransformGroup.Children)[3].(TranslateTransform.X)�$ 	StackMenu��.\�  $ 0��$ 0Q�  $ 0:0:0.5��$	 250Q�   $	 EaseIn=�$
 -3Q� � Triggers :�  :� RoutedEvent$ ButtonBase.Click�� :� 
SourceName$ 
ButtonMenu��.[��� -    ��Name$ OpenMenu_BeginStoryboard��#��[ :� $ ButtonBase.Click��$ ButtonClose��.[��� #��[  :� $ Selector.SelectionChanged��$ ListViewMenu��.[��� #��[  .��� ���	#FFAFFFFF.+�� -    �Name$ GridMain��$��0 60 0 0q��� $��50��$��50��$��Right=�$��Bottom=�$��20q�$��Assets/log.jpg��� $��60��$	��Top=� � ColumnDefinitions �� $
��126* ��� $	��23* �.+��� $!��Личные финансы��$��Center=�$��Center=�$��24(�$��496,12,312.252,12q��� -    ��Name$ 
ButtonMenu��$��Center=�$
��Left=�$��40��$��40��$��0q�$��
10,10,0,10q���Z� ��Z� .��'  !MaterialDesignThemes.Wpf.PackIcon     Kind$
 Menu=�$��25��$��25�����	#FF009CDE���	#FF009CDE�� -    ��Name$ 	StackMenu��$	��250��$
��Left=����	#FF009CDE J� RenderTransformOrigin$ 0.5,0.5&�$��-250, 0, 0, 0q�z�V� .~��� �� �� T� .+�� $	��180������  �� ImageSource$ Assets/finance.jpg��.+�� ���	#CDDBD9EE�� -   $ ButtonClose��$��Right=�$	��Top=�$��0q�$��10q���Z� ��Z� .��  -     Name$ packIcon��$ CloseOutline=�$��25��$��25�����	#FF009CDE�� -    ��Name$ ListViewMenu�� �� SelectedIndex$ 0��$2��,/Project;component/Fonts/#EngraversGothic BT)�
����������� *
MenuItem+���� .R���  �� Orientation$ 
Horizontal=�.+�  $��25��$��25��$��10q� �� *Icon+�� $��18(�$��Center=����� *Title+�� $��Right=�$��Bottom=�$��8(� J� Opacity$	 0.8Q�$
��10 0q����� 