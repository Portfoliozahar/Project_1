   M S B A M L   `   `   `  ���� B  >Project, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null!clr-namespace:ProjectProject  #    Project.WindowEditTransaction   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     @d2http://schemas.microsoft.com/expression/blend/2008     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     'localclr-namespace:Project     _ [MaterialDesignThemes.Wpf, Version=4.9.0.0, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes    � WindowStyle$
  None=� � WindowStartupLocation$ CenterScreen=� � 
ResizeMode$ NoResize=�
�������$	��300��$	��300��$��EngraversGothic BT)�.���� .+�� $��1q�
�������$	��Top=�$	��300��.+��� -    ��Name$ 
ButtonSave��$��Right=�$��Bottom=�$��10q�.��'  !MaterialDesignThemes.Wpf.PackIcon     Kind$ Check=��� ���	#FF073E6A$��22(�$��10q�$��Center=�$��Center=�����  �� Path$
 Kind��� -   $ ButtonClose��$
��Left=�$��Bottom=�$��10q�.��  $ 	ArrowLeft=��� .+��� $��0 15 0 0q�$	��250��)  #MaterialDesignThemes.Wpf.HintAssist   Hint$
 Nome��$��Center=�$��25(����� $ Description���  �� TextAlignment$
 Left=�$��
15 5 15 15q�$	��250��$
 Nome��$��Center=�$��35(����� $ Value� �� StringFormat$ {0:C}��(  "System.Windows.Controls.DatePicker  -   	  Name$	 DatePickerData��$	��250��$ Изменить дату��$��Center=�$��15q�
   SelectedDate
 �� $
 Date� �� Mode$ OneWay=��� -    ��Name$ ComboBoxCategory��$	��250��$��15q�$' !Измнить категорию��$��Center=� �� Text �� $ Category.Name� �� 
GroupStyle (  "System.Windows.Controls.GroupStyle     HeaderTemplate �� .R��� $	��5 0q����� *Name+���� .R��� ���� *Name+