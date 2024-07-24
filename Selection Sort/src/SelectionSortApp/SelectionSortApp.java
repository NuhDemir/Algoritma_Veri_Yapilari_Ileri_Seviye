package SelectionSortApp;
import javax.swing.*;
import java.awt.*;
import java.awt.event.ActionEvent;
import java.awt.event.ActionListener;

public class SelectionSortApp {
    public static void main(String[] args) {
        SwingUtilities.invokeLater(() -> {
            JFrame frame = new JFrame("Selection Sort Öğretici");
            frame.setDefaultCloseOperation(JFrame.EXIT_ON_CLOSE);
            frame.setSize(1200, 600);
            frame.setLayout(new BorderLayout());

            // SelectionSortVisualizer bileşenini oluştur
            SelectionSortVisualizer visualizer = new SelectionSortVisualizer();
            frame.add(visualizer, BorderLayout.CENTER);

            // Paneli ve bileşenleri oluştur
            JPanel inputPanel = new JPanel();
            inputPanel.setBackground(new Color(0xF8F991));
            inputPanel.setLayout(new FlowLayout());

            JLabel lengthLabel = new JLabel("Dizi Uzunluğu:");
            JTextField lengthField = new JTextField(5);
            JButton generateButton = new JButton("Diziyi Oluştur ve Başlat");

            inputPanel.add(lengthLabel);
            inputPanel.add(lengthField);
            inputPanel.add(generateButton);

            frame.add(inputPanel, BorderLayout.NORTH);

            // Başlat butonuna tıklanınca diziyi oluştur ve sıralama işlemini başlat
            generateButton.addActionListener(new ActionListener() {
                @Override
                public void actionPerformed(ActionEvent e) {
                    try {
                        int length = Integer.parseInt(lengthField.getText());
                        if (length <= 0) {
                            JOptionPane.showMessageDialog(frame, "Dizi uzunluğu pozitif bir sayı olmalıdır.", "Hata", JOptionPane.ERROR_MESSAGE);
                            return;
                        }
                        visualizer.generateRandomArray(length);
                        visualizer.startSorting();
                    } catch (NumberFormatException ex) {
                        JOptionPane.showMessageDialog(frame, "Lütfen geçerli bir sayı girin.", "Hata", JOptionPane.ERROR_MESSAGE);
                    }
                }
            });

            frame.setVisible(true);
        });
    }
}
