   M S B A M L   `   `   `  ����I  EJadens Manager, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null/clr-namespace:Jadens_ManagerJadens_Manager  5   	       Jadens_Manager.MainWindow   5   	   W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   .localclr-namespace:Jadens_Manager     5   	   -   5          � Title$  Jadens Manager��5   	   $	��450��6    $	��800��6-   ���	#00000000���	#00000000$��Bahnschrift Light)�6g   $
��Bold"�6�    � WindowStyle$
 None=�6�    � 
ResizeMode$ NoResize=�6�    � AllowsTransparency$
 True��5	   	    � 	Resources 5       �� 
TargetType �� Property �� Value �� 
TargetType	 ]� Thumb
 �� CornerRadius ]� DecreaseRepeatButton ]� IncreaseRepeatButton��%�  '��       �� 5   
   " ��6   .�5      ��  � ��
 �����6+   �� 5       � ��
 �����6+   �� 5       � �� 5      �� 5      " ��6&   .R�5      � #��z��6   .+�5      ]� $��
PART_Track��6$   $
��True��5   $   	 5   "   n� 5   &   ���	#FF2D2D2D���	#FF5A5A5A$��2q�5   ,   ��5   *   �� 5   .   " n�6>   .R�5    2   �� #��z��5!   5   #��z��5"   5   #��z��5#   5   $
 2��5$   5   ._�5%   6   �� 5&   3   5'   /   5)   '    5,   "   �� 5-   &   ���	#FF17171763    5/   "   �� 50   &   ���	#FF171717���	#007070706J   52      53      54      56      57      58      .��59      �� $
 15��6   
���   ����	#FF101010$��3q�6J   ._�5:   
   �  � RowDefinitions 5;      �� 5<      $��* �6    6-   �� 5=      $��7* �6    6.   �� 5>      $��* �6    6-   .+�5@      �� -   5        $��
DragCanvas��5@      
������ $��0��6@   $��15��6M   $��Stretch=�6Y   $	��Top=�6w    � Cursor$ SizeAll��6�   A� 5A      -   5        
���  ��$��0��5A   !   $��15��6.   $��15��6:   $��Right=�6E   $	��Top=�6a   $��	0,10,10,0q�6y    � ToolTip$
 Exit��6�   $
 Hand��6�   6�   A� 5B      -   5        
��� ���$��0��5B   $   $��15��61   $��15��6=   $��Right=�6H   $	��Top=�6d   $��	0,10,30,0q�6|   $ Minimize��6�   $
 Hand��6�   6�   �� 5C      -   5        $��ImportDataButton��5C      $��2��6-   $��Bottom=�6:   $��Center=�6U   $��Import Data��6r   $	��150��6�   $��30��6�   ���	#FF191919���	#FF333333
�������$��
0,0,190,10q�6  6  �� 5D      -   5        $��SaveDataButton��5D      $��2��6+   $��Bottom=�68   $��Center=�6S   $��	Save Data��6p   $	��150��6�   $��30��6�   ���	#FF191919���	#FF333333
�������$��
190,0,0,10q�6�   6  �� 5E      -   5        $��1��5E      ���	#FF0E0E0E$
��Auto=�6?    J� 	AllowDrop$
 True��6b   .��5F      �� -   5        $��PasswordsStackPanel��5F      .+�5G      �� -	   5        $��AddPasswordButton��5G      $��Add New Password��66   $	��130��6Q   ���	#FF3A3A3A
�������$
��Left=�6�   $��	10,10,0,0q�6�   6�   5J      5K      5L      5M      5P      