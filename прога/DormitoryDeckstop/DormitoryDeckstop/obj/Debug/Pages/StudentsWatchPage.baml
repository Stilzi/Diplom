   M S B A M L   `   `   `  ����L  HDormitoryDeckstop, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullA%clr-namespace:DormitoryDeckstop.PagesDormitoryDeckstop.Pages  5      /    )DormitoryDeckstop.Pages.StudentsWatchPage   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      7local%clr-namespace:DormitoryDeckstop.Pages     5      -   5          N� Title$  StudentsWatchPage��5	       � 	Resources 5       �� 
TargetType �� Property �� Value��%Z   '��       �� 5   
   " ��6   .�5      ��  � ��$ 
Montserrat)�6+   5      5      .��5      � 
�������.+�5   
   � ��5      �� 5       �� ImageSource$U OD:\проекты\дипломная\zdaniia_vecher_fasady_166772_1920x1080.jpg��6   .+�5      � 
���   � J� Opacity$	 0.8Q�5      5      � 5   
    � RowDefinitions 5      �� 5      $
��0.3* �6    60   �� 5      6"   .+�5      �� -   5         ��Name$
 back��5      $	��150��5      $��35��5       $��
Назад��5!      $��0��5"      $
��Left=�5#      $	��Top=�5$      $��20q�5%      6   �� 5&      $��Поиск:��6   $��24(�5'      
�������$��0��5)      $��Right=�5*      $��Center=�5+      $��	0 0 520 0q�5,      �� 5-      -   5        	 ��Name$	 search��5-      $	��450��5.      $��45��5/      
�������$��Right=�51      $��Center=�52      $��40q�53      $��0��54      6#   &   System.Windows.Controls.DataGrid  55      -   5        
  Name$
 datagrid��56      $��1��55         AutoGenerateColumns .     
IsReadOnly .     Columns 59      0  *System.Windows.Controls.DataGridTextColumn  5:      ,  &System.Windows.Controls.DataGridColumn   Header$ Id��6)   1  +System.Windows.Controls.DataGridBoundColumn   Binding 65   �� *Id+  5;      $ ФИО��6)      Width5  /System.Windows.Controls.DataGridLengthConverter$
 0.5* 66    6C   �� *Name+  5<      $ Группа��6)   $
 0.5* 69    6F   �� *Group.NumberGroup+  5=      $ Комната��6)   $
 0.5* 6:    6G   �� *Rooms.Number+5?      5@      5A      5B      