   M S B A M L   `   `   `  ����?  ;Hoya, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null%clr-namespace:Hoya.View	Hoya.View  5   	       Hoya.View.LoadingView   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35a ]DevExpress.Xpf.Core.v19.2, Version=19.2.5.0, Culture=neutral, PublicKeyToken=b88d1754d700e49aR NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   )localclr-namespace:Hoya.View     5   	   
������   � WindowStartupLocation$  CenterScreen=�5	       � AllowsTransparency .  � WindowStyle$
 None=�5   
    � Title$ Loading��5   	   $��40��5   
   $	��100��6    � Triggers 5      :� 5   
    :� RoutedEvent$ Loaded��6   .[�5      �� .��5      ��  g� Duration$ 00:00:1D�6    �� TargetProperty$ Opacity�60   .��5      W�  W� From$ 0X�6&   		 W� To$	 1X�6/   5      5      5      .��5      � .+�5   
   � $��Center=�5      
 � IsIndeterminate
 .  � Value$ 0Q�5      $	��100��6   ��5      �� 5      .��5       �  � Color$ 	#FF006CB7��6#    � Offset$	 0.3Q�65   5!      5#      �� 5$   
   $��
Loading...��5%      
���   �$��Center=�5'      $��Center=�5(      $��20(�62   5*      5+      