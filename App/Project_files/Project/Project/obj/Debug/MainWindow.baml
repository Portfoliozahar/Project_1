   M S B A M L   `   `   `  ����B  >Project, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null!clr-namespace:ProjectProject  5   	       Project.MainWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   'localclr-namespace:Project     5   	   _ [MaterialDesignThemes.Wpf, Version=4.9.0.0, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5   	   -   5        $	��600��5   R   $
��1200��6_     � WindowStartupLocation$  CenterScreen=�6l   $6��0/Project;component/Fonts/#Champagne & Limousines)�6�    � Icon$ Assets/log.jpg��6�    � WindowState$ 	Maximized=�6  $	��550��6  $
��1080��6.   � 	Resources 5	         	CloseMenu �� TargetProperty �� 
TargetName9  3System.Windows.Media.Animation.EasingDoubleKeyFrame O� KeyTime O� Value   EasingFunction-  'System.Windows.Media.Animation.BackEase7  1System.Windows.Media.Animation.EasingFunctionBase	   
EasingMode
   	Amplitude  OpenMenu��%�  &	        &	 @    �� 5
   
   .��5      U� $U O(UIElement.RenderTransform).(TransformGroup.Children)[3].(TranslateTransform.X)�6,   $ 	StackMenu��6�   .\�5        $ 0��6'   $	 250Q�63     5      $ 0:0:0.5��6'   $ 0Q�69    5        5      $	 EaseIn=�6#   $
 -3Q�67   5      5      5      �� 5   
   .��5      U� $U O(UIElement.RenderTransform).(TransformGroup.Children)[3].(TranslateTransform.X)�6,   $ 	StackMenu��6�   .\�5        $ 0��6'   $ 0Q�63     5      $ 0:0:0.5��6'   $	 250Q�69    5        5      $	 EaseIn=�6#   $
 -3Q�67   5      5      5      5       � Triggers 5      :� 5    
    :� RoutedEvent$ ButtonBase.Click��6    :� 
SourceName$ 
ButtonMenu��66   .[�5!      �� -   5         ��Name$ OpenMenu_BeginStoryboard��5!      #��[ 6@   5"      :� 5#   
   $ ButtonBase.Click��6   $ ButtonClose��66   .[�5$      �� #��[  6   5%      :� 5&   
   $ Selector.SelectionChanged��6   $ ListViewMenu��6?   .[�5'      �� #��[  6   5(      .��5*      � ���	#FFAFFFFF.+�5+   
   � -   5         �Name$ GridMain��5+      $��0 60 0 0q�6!   �� 5,   
   $��50��6   $��50��6   $��Right=�6'   $��Bottom=�6C   $��20q�6^   $��Assets/log.jpg��6j   � 5-   
   $��60��6   $	��Top=�6    � ColumnDefinitions 5.      �� 5/      $
��126* �6#   �� 50      $	��23* �6#   .+�56      �� $!��Личные финансы��6   $��Center=�6-   $��Center=�6J   $��24(�6e   $��496,12,312.252,12q�6s   �� 57      -   5         ��Name$ 
ButtonMenu��57      $��Center=�6?   $
��Left=�6Z   $��40��6u   $��40��6�   $��0q�6�   $��
10,10,0,10q�6�   ��6)   Z� ��6�   Z� .��58      '  !MaterialDesignThemes.Wpf.PackIcon     Kind$
 Menu=�6*   $��25��66   $��25��6B   ���	#FF009CDE���	#FF009CDE6d   59      5:      �� 5;   
   -   5         ��Name$ 	StackMenu��5;      $	��250��6(   $
��Left=�64   ���	#FF009CDE J� RenderTransformOrigin$ 0.5,0.5&�6f   $��-250, 0, 0, 0q�6�   z�5<      V� 5=      .~�5>      �� �� 5?      �� 5@      T� 5A      5B      .+�5D      � $	��180��6   ��5E      �� 5F       �� ImageSource$ Assets/finance.jpg��6!   .+�5H      � ���	#CDDBD9EE6   �� 5I      -   5        $ ButtonClose��5I      $��Right=�6.   $	��Top=�6J   $��0q�6�   $��10q�6�   ��6b   Z� ��6x   Z� .��5J        -   5          Name$ packIcon��5J   .   $ CloseOutline=�6@   $��25��6T   $��25��6_   ���	#FF009CDE6k   5K      5L      �� 5M      -   5         ��Name$ ListViewMenu��5M       �� SelectedIndex$ 0��6^   $2��,/Project;component/Fonts/#EngraversGothic BT)�6p   
���������6�   �� *
MenuItem+��5N      �� 5O      .R�5P      ��  �� Orientation$ 
Horizontal=�6%   .+�5Q        $��25��6L   $��25��6W   $��10q�6c    66   �� *Icon+6c   �� 5R      $��18(�6?   $��Center=�6M   ��6(   �� *Title+6M   5S      5T      5V      5W      �� 5X   
   $��Right=�6$   $��Bottom=�6@   $��8(�6[    J� Opacity$	 0.8Q�6h   $
��10 0q�6v   ��6   �� 6v   5Z      5[      