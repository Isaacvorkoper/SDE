   M S B A M L   `   `   `  ����M  IWpfControlTempDemo, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null7 clr-namespace:WpfControlTempDemoWpfControlTempDemo  5   	   #    WpfControlTempDemo.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   2local clr-namespace:WpfControlTempDemo     5   	     � Title$  
MainWindow��5   	   $	��350��6   $	��604��6-    � 	Resources 5
         ButtonTemplate �� 
TargetType A�Name �� 
StartPoint �� EndPoint � Offset � Color �� Triggers	 P� Property
 P� Value �� 
TargetName �� Property �� Value �� ScaleX �� ScaleY �� CenterX �� CenterY��%z  &	        �� 5   
   " ��63   .R�5      � .+�5      A� $ ButtonEllipse��6   $	��100��63   $	��150��6B   ��5      �� 5      $ 0,0.2&�6.   $ 0.2,1.4&�6C   .��5      � $ 0Q�6+   $	 Red��68   � 5      $ 1Q�6+   $ Orange��68   5      5      �� 5      #��z��6#   $��Center=�5      $��Center=�6/   5       5      P� 5      	 �@J�IsMouseOver
 . . �5      �� $ ButtonEllipse��6    � �� 5      �� 5       $ 0,0.2&�62   $ 0.2,1.4&�6G   .��5!   "   � $ 0Q�6/   $ YellowGreen��6<   � 5"   "   $ 1Q�6/   $
 Gold��6<   5#      5%      5&      P� 5(      	 � ��
 . . �5)      ��  � z� 5*      �� 5+      $	 0.8Q�6-   $	 0.8Q�6<   $ 0Q�5,      $ 0Q�6'   5.      �� 5/       �@J�RenderTransformOrigin$ 0.5,0.5&�6@   50      54      55      .��57      �� .+�58   
   �� $��Round Button!��6   #��[  59   
   $	��150��5:   
   $��50q�6   �� 5;   
   $��Default Button!��6   $��40��6-   $	��150��5<   
   $��5q�6   5=      5?      