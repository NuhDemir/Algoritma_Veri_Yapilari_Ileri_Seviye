package SelectionSortApp;
import javax.swing.*;
import java.awt.*;
import java.awt.event.ActionEvent;
import java.awt.event.ActionListener;
import java.util.Random;

public class SelectionSortVisualizer extends JPanel {
    private static final int WIDTH = 900;
    private static final int HEIGHT = 400;
    private static final int BAR_WIDTH = 30;
    private int[] array;
    private int currentIndex = 0;
    private int minIndex = 0;
    private int step = 0;
    private Timer timer;
    private JTextArea explanationArea;

    public SelectionSortVisualizer() {
        setPreferredSize(new Dimension(WIDTH, HEIGHT));
        setBackground(new Color(0x444B6E));
        setLayout(new BorderLayout());

        // Açıklama metni için JTextArea oluştur
        explanationArea = new JTextArea();
        explanationArea.setEditable(false);
        explanationArea.setPreferredSize(new Dimension(300, HEIGHT));
        explanationArea.setBorder(BorderFactory.createEmptyBorder(10, 10, 10, 10));
        explanationArea.setBackground(new Color(0x9AB87A));
        explanationArea.setForeground(Color.BLACK);
        add(explanationArea, BorderLayout.EAST);

        // Zamanlayıcıyı oluştur
        timer = new Timer(500, new ActionListener() {
            @Override
            public void actionPerformed(ActionEvent e) {
                step();
                repaint();
                updateExplanation();
            }
        });
    }

    // Diziyi ve adımları sıfırla
    public void reset() {
        currentIndex = 0;
        minIndex = 0;
        step = 0;
        updateExplanation();
        repaint();
    }

    // Kullanıcı tarafından girilen uzunlukta rastgele bir dizi oluştur
    public void generateRandomArray(int length) {
        array = new int[length];
        Random rand = new Random();
        for (int i = 0; i < length; i++) {
            array[i] = rand.nextInt(100) + 1; // 1 ile 100 arasında rastgele sayılar
        }
        reset();
    }

    // Selection sort algoritmasını başlat
    public void startSorting() {
        if (array == null || array.length == 0) {
            JOptionPane.showMessageDialog(this, "Dizi boş veya tanımlanmamış!", "Hata", JOptionPane.ERROR_MESSAGE);
            return;
        }
        timer.start();
    }

    // Her adımda yapılacak işlemler
    private void step() {
        if (currentIndex < array.length - 1) {
            if (step == 0) {
                minIndex = currentIndex;
                step++;
            } else if (step == 1) {
                for (int i = currentIndex + 1; i < array.length; i++) {
                    if (array[i] < array[minIndex]) {
                        minIndex = i;
                    }
                }
                step++;
            } else if (step == 2) {
                int temp = array[minIndex];
                array[minIndex] = array[currentIndex];
                array[currentIndex] = temp;
                currentIndex++;
                step = 0;
            }
        } else {
            timer.stop(); // Sıralama işlemi tamamlandığında zamanlayıcıyı durdur
        }
    }

    // Açıklama metnini güncelle
    private void updateExplanation() {
        StringBuilder explanation = new StringBuilder();
        explanation.append("Adım: ").append(currentIndex + 1).append("\n");

        if (step == 0) {
            explanation.append("En küçük elemanı bulmak için başla.\n");
        } else if (step == 1) {
            explanation.append("Kalan diziyi tarayıp en küçük elemanı bul.\n");
        } else if (step == 2) {
            explanation.append("Bulduğun en küçük elemanı şu anki elemanla yer değiştir.\n");
        }

        explanation.append("\nDizi Durumu:\n");
        for (int i = 0; i < array.length; i++) {
            explanation.append(array[i]).append(" ");
        }
        explanationArea.setText(explanation.toString());
    }

    @Override
    protected void paintComponent(Graphics g) {
        super.paintComponent(g);
        if (array != null) {
            drawArray(g);
        }
    }

    // Diziyi çiz
    private void drawArray(Graphics g) {
        Graphics2D g2d = (Graphics2D) g;
        for (int i = 0; i < array.length; i++) {
            if (i == currentIndex) {
                g2d.setColor(new Color(0x708B75)); // Geçerli eleman rengi
            } else if (i == minIndex) {
                g2d.setColor(new Color(0x3D315B)); // Minimum eleman rengi
            } else {
                g2d.setColor(new Color(0xF8F991)); // Diğer eleman rengi
            }
            g2d.fillRect(i * BAR_WIDTH, HEIGHT - array[i] * 3, BAR_WIDTH - 2, array[i] * 3);
        }
    }
}
