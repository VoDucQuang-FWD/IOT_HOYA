   M S B A M L   `   `   `  ����?  ;Hoya, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:HoyaHoya  5   	   /clr-namespace:Hoya.ViewModelHoya.ViewModel  5   	       Hoya.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35a ]DevExpress.Xpf.Core.v19.2, Version=19.2.5.0, Culture=neutral, PublicKeyToken=b88d1754d700e49aR NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   $localclr-namespace:Hoya     5   	   c _System.Windows.Interactivity, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35Bi:http://schemas.microsoft.com/expression/2010/interactivity  5   	   ,	viewmodelclr-namespace:Hoya.ViewModel  5   	    
  MainVM  � DataContext#  [  5
   	    � WindowStartupLocation$ CenterScreen=�5   	    � Title$	 IOT��5   	   $	��500��6   $	��800��6"   .  (System.Windows.Interactivity.Interaction   Triggers 5      /  )System.Windows.Interactivity.EventTrigger  5   
      	EventName$ Loaded��6   .  (System.Windows.Interactivity.TriggerBase   Actions. 5      6  0System.Windows.Interactivity.InvokeCommandAction     Command 6%   �� *Loaded+5        5   
   $ Unloaded��6   . 5         6$   �� *
Unloaded+5      .��5      �  � ColumnDefinitions 5   
   �� 5      �� 5      $	��250 �6   .+�5   
   � $��1��6   $��1��6    K� ZIndex$ 1��6-   	 � RowDefinitions	 5       �� 5"      $��1 �6    �� 5#      $��30 �6    �� 5$      $��40 �6    �� 5%      $��50 �6    �� 5&      $��30 �6    �� 5'      $��30 �6    �� 5(      $��30 �6    �� 5)      $��30 �6    �� 5*      $��50 �6    �� 5+      .+�5.      �� $��1��6   $��Đơn vị thực hiện��6!   ���	#FFB94545$��15(�6S   $��Center=�6a   $��Center=�6|   �� 5/      $��2��6   $��Công ty TNHH MTV FWD��6!   ���	#FFB94545$��15(�6W   $��Center=�6e   $
��Left=�6�   �� 50      $��3��6   $��5q�6%   $K��EĐịa chỉ: 125 Võ An Ninh - Hòa Xuân Cẩm Lệ - Đà nẵng  ��60   ���	#FFB94545$��Center=�6�   $
��Left=�6�   $
��Wrap=�51      $��15(�6,   �� 52      $��4��6   $��Email: Fwd2021@gmail.com��6!   ���	#FFB94545$��15(�6[   $��Center=�6i   $
��Left=�6�   �� 53      $��5��6   $��SĐT: 093 500 93 58��6!   ���	#FFB94545$��15(�6U   $��Center=�6c   $
��Left=�6~   �� 54      $��6��6   $+��%Liên hệ: PHẠM NGUYỄN PHÚ VINH��6!   ���	#FFB94545$��15(�6`   $��Center=�6n   $
��Left=�6�   �� 55      $��8��6   
�������$��25(�69   $��Center=�6G   $��Center=�6b   ��56      �� 57      
 �� 
TargetType"
 ��6   .�58      ��  �� Property � �� �� Value$ IOT SMART FACTORY��61    �� Triggers 59      :� 5:       :� RoutedEvent$ Window.Loaded��6+   .[�5;   "   ��   Runtext#��[ 62   5<      5>      5@      �� 5A      $��Center=�6   $��10��66   $��Center=�6D   .+�5B      �� $��9��65   $��Center=�6B   $��Center=�6`   $��	DASHBOARD��6{   $	��100��6�   $��50��6�   $
��Bold"�6�   ���	#FF2247A8��6   �� *DBHOYA+��6�   Z� 5D      �� 5E      $��0,10,0,0q�6   $��9��6G   $��Center=�6T   $��Center=�6r   $�� ��6�   $	��100��6�   $��50��6�   $
��Bold"�6�   ���	#FF2247A8��6,   �� *DBHOYA+��6�   Z� 5G      5I      5L      �� 5N   
   $��1��6   $��3��6   $
��Fill=�6M   ��61   �� *
imageiot+6M   5O      5P      