   M S B A M L   `   `   `  ����B  >Project, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null!clr-namespace:ProjectProject  5   	   #    Project.WindowEditTransaction   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   'localclr-namespace:Project     5   	   _ [MaterialDesignThemes.Wpf, Version=4.9.0.0, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5   	     � WindowStyle$
  None=�5	   	    � WindowStartupLocation$ CenterScreen=�6    � 
ResizeMode$ NoResize=�6A   
�������$	��300��6n   $	��300��6z   $��EngraversGothic BT)�6�   .��5
      �� .+�5   
   � $��1q�6   
�������$	��Top=�6-   $	��300��6E   .+�5      �� -   5         ��Name$ 
ButtonSave��5      $��Right=�6)   $��Bottom=�6E   $��10q�6`   .��5      '  !MaterialDesignThemes.Wpf.PackIcon     Kind$ Check=�6*   5      �� 5      ���	#FF073E6A$��22(�6J   $��10q�6X   $��Center=�6d   $��Center=�6   ��6   ��  �� Path$
 Kind�6   �� 5      -   5        $ ButtonClose��5      $
��Left=�6*   $��Bottom=�6E   $��10q�6`   .��5        $ 	ArrowLeft=�6*   5      5      �� 5   
   .+�5      �� $��0 15 0 0q�6:   $	��250��6L   )  #MaterialDesignThemes.Wpf.HintAssist   Hint$
 Nome��6X   $��Center=�6~   $��25(�6�   ��6   �� $ Description�6�   �� 5       �� TextAlignment$
 Left=�6J   $��
15 5 15 15q�6_   $	��250��6s   $
 Nome��6   $��Center=�6�   $��35(�6�   ��6   �� $ Value� �� StringFormat$ {0:C}��6�   (  "System.Windows.Controls.DatePicker  5      -   5        	  Name$	 DatePickerData��5      $	��250��61   $ Изменить дату��6=   $��Center=�6l   $��15q�6�   
   SelectedDate
 6�   �� $
 Date� �� Mode$ OneWay=��� 5      -   5         ��Name$ ComboBoxCategory��5      $	��250��61   $��15q�6=   $' !Измнить категорию��6I   $��Center=�6|    �� Text 6�   �� $ Category.Name� �� 
GroupStyle 5      (  "System.Windows.Controls.GroupStyle  5         HeaderTemplate 5      �� 5      .R�5   "   �� $	��5 0q�6B   ��6,   �� *Name+6B   5      5       ��5"      �� 5#      .R�5$      �� ��6$   �� *Name+5%      5'      5(      5)      5*      