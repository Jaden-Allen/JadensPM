   M S B A M L   `   `   `  ���� I  EJadens Manager, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null/clr-namespace:Jadens_ManagerJadens_Manager      Jadens_Manager.MainWindow   W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     @d2http://schemas.microsoft.com/expression/blend/2008     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     .localclr-namespace:Jadens_Manager     -     � Title$  Jadens Manager��$	��450��$	��800�����	#00000000���	#00000000$��Bahnschrift Light)�$
��Bold"� � WindowStyle$
 None=� � 
ResizeMode$ NoResize=� � AllowsTransparency$
 True�� � 	Resources  �� 
TargetType �� Property �� Value �� 
TargetType	 ]� Thumb
 �� CornerRadius ]� DecreaseRepeatButton ]� IncreaseRepeatButton��%H  '��       �� " ��.���  � ��
 �������  � ��
 �������  � �� �� " ��.R�� #��z��.+�]� $��
PART_Track��$
��True��	 n� ���	#FF2D2D2D���	#FF5A5A5A$��2q����� " n�.R��� #��z��#��z��#��z��$
 2��._���  �� ���	#FF171717 �� ���	#FF171717���	#00707070.���� $
 15��
���   ����	#FF101010$��3q�._��  � RowDefinitions �� $��* ��� $��7* ��� $��* �.+��� -   $��
DragCanvas��
������ $��0��$��15��$��Stretch=�$	��Top=� � Cursor$ SizeAll��A� -   
���  ��$��0��$��15��$��15��$��Right=�$	��Top=�$��	0,10,10,0q� � ToolTip$
 Exit��$
 Hand��A� -   
��� ���$��0��$��15��$��15��$��Right=�$	��Top=�$��	0,10,30,0q�$ Minimize��$
 Hand���� -   $��ImportDataButton��$��2��$��Bottom=�$��Center=�$��Import Data��$	��150��$��30�����	#FF191919���	#FF333333
�������$��
0,0,190,10q��� -   $��SaveDataButton��$��2��$��Bottom=�$��Center=�$��	Save Data��$	��150��$��30�����	#FF191919���	#FF333333
�������$��
190,0,0,10q��� -   $��1�����	#FF0E0E0E$
��Auto=� J� 	AllowDrop$
 True��.���� -   $��PasswordsStackPanel��.+��� -	   $��AddPasswordButton��$��Add New Password��$	��130�����	#FF3A3A3A
�������$
��Left=�$��	10,10,0,0q�